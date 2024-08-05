using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    bool Stream,
    string Path,
    string RequestMediaType,
    ImmutableArray<PropertyData> Properties,
    OperationType HttpMethod,
    ContentType ContentType,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    bool IsDeprecated,
    bool IsMultipartFormData,
    TypeData RequestType,
    TypeData ResponseType,
    ImmutableArray<ModelData> AdditionalModels,
    ImmutableArray<TypeData> AdditionalTypes,
    ImmutableArray<string> Converters
)
{
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    
    public string FileNameWithoutExtension => string.IsNullOrWhiteSpace(Path)
        ? $"{Namespace}.{ClassName}"
        : $"{Namespace}.{ClassName}.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(
        KeyValuePair<OperationType, OpenApiOperation> operation,
        Settings settings,
        string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        
        var requiredParameters = new HashSet<string>((operation.Value.Parameters ?? [])
            .Where(x => x.Required || x.In == ParameterLocation.Path)
            .Select(x => x.Name));
        var parameters = (operation.Value.Parameters ?? [])
            .Select(x => PropertyData.FromSchema(
                schema: x.Schema.WithKey(x.Name),
                requiredProperties: requiredParameters,
                parameterLocation: x.In,
                parameterStyle: x.Style,
                parameterExplode: x.Explode,
                operationId: operation.Value.OperationId,
                settings: settings,
                parents: []))
            .ToArray();
        
        // Ensure that parameters with the same name are unique
        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].Name == duplicateParameter)
                {
                    parameters[i] = parameters[i] with
                    {
                        Name = $"{parameters[i].Name}{index++}",
                    };
                }
            }
        }
        
        var preparedPath = path.PreparePath(parameters);

        var id = operation.Value.GetMethodName(
            path: path,
            operationType: operation.Key,
            settings.MethodNamingConvention,
            settings.MethodNamingConventionFallback);
        var objectParameters = (operation.Value.Parameters ?? [])
            .Where(x => x.Schema.Type == "object")
            .Select(x => ModelData.FromSchema(
                    x.Schema.WithKey(id + x.Name.ToPropertyName()),
                    settings))
            .ToArray();
        var enumParameters = (operation.Value.Parameters ?? [])
            .Where(x => x.Schema.Enum?.Any() == true || x.Schema.Items?.Enum?.Any() == true)
            .Select(x => ModelData.FromSchema(
                    x.Schema.WithKey(operation.Value.OperationId + x.Name.ToPropertyName()),
                    settings) with
                {
                    Style = ModelStyle.Enumeration,
                    Properties = (x.Schema.Enum?.Any() == true
                        ? x.Schema.Enum
                        : x.Schema.Items.Enum)
                    .Select(value => value.ToEnumValue(settings))
                    .Where(value => !string.IsNullOrWhiteSpace(value.Name))
                    .ToImmutableArray(),
                })
            .ToArray();
        var requestMediaTypes =
            operation.Value.RequestBody?.ResolveIfRequired().Content ??
            new Dictionary<string, OpenApiMediaType>();
        var requestBodyModels = requestMediaTypes
            .Where(x =>
                x.Value.Schema != null &&
                (x.Value.Schema.Type == "object" ||
                (x.Value.Schema.Type == "array"
                && x.Value.Schema.Items?.Type == "object") ||
                x.Value.Schema.AnyOf is { Count: > 0 } ||
                x.Value.Schema.OneOf is { Count: > 0 } ||
                x.Value.Schema.AllOf is { Count: > 0 }))
            .SelectMany(x => ModelData.FromSchemas(
                x.Value.Schema!,
                settings,
                id + "Request"))
            .SelectMany(model => model.WithAdditionalModels())
            .ToArray();
        var requestBodyTypes = requestMediaTypes
            .Where(x => x.Value.Schema != null)
            .Select(x => TypeData.FromSchema(
                x.Value.Schema!.UseReferenceIdOrKey(id + "Request"),
                settings))
            .ToArray();
        
        ModelData? requestModel = requestBodyModels.Length == 0
            ? null
            : requestBodyModels.First();
        TypeData? requestType = requestBodyTypes.Length == 0
            ? null
            : requestBodyTypes.First();
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";
        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }
        
        var responses = (operation.Value.Responses ?? [])
            .SelectMany(x => x.Value?.ResolveIfRequired().Content?.Select(y => (Response: x, MediaType: y)) ?? [])
            .ToArray();
        var responseModels = responses
            .Select(x => x.MediaType.Value.Schema)
            .Where(schema =>
                schema != null &&
                (schema.Type == "object" ||
                 schema is { Type: "array", Items.Type: "object" } ||
                 schema.AnyOf is { Count: > 0 } ||
                 schema.OneOf is { Count: > 0 } ||
                 schema.AllOf is { Count: > 0 }))
            .SelectMany(schema => ModelData.FromSchemas(
                schema!,
                settings,
                key: id + "Response"))
            .SelectMany(model => model.WithAdditionalModels())
            .ToArray();
        var responseTypes = responses
            .Select(x => x.MediaType.Value.Schema)
            .Select(schema => schema != null
                ? TypeData.FromSchema(
                    schema.UseReferenceIdOrKey(id + "Response"),
                    settings)
                : TypeData.Default)
            .ToArray();
        TypeData? responseType = responseTypes.Length == 0
            ? null
            : responseTypes.First();

        var properties = parameters.ToList();
        foreach (var requestProperty in requestModel?.Properties ?? [])
        {
            if (properties.All(x => x.Name != requestProperty.Name))
            {
                properties.Add(requestProperty);
            }
            else
            {
                properties.Add(requestProperty with
                {
                    Name = $"request{requestProperty.Name.ToPropertyName()}",
                });
            }
        }
        
        var firstTag = (operation.Value.Tags ?? []).FirstOrDefault();
        var endPoint = new EndPoint(
            Id: id,
            Namespace: settings.Namespace,
            ClassName: settings.GroupByTags && firstTag != null
                ? firstTag.Name.ToClassName() + "Client"
                : settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: responses
                .Any(x => x.MediaType.Key.Contains("application/x-ndjson")),
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Properties: properties.ToImmutableArray(),
            HttpMethod: operation.Key,
            ContentType: responses
                .Any(x => x.MediaType.Key.Contains("application/octet-stream"))
                ? ContentType.ByteArray
                : ContentType.String,
            Summary: operation.Value.GetXmlDocumentationSummary(),
            BaseUrlSummary: string.Empty,
            Settings: settings,
            IsDeprecated: operation.Value.Deprecated,
            IsMultipartFormData: operation.Value.RequestBody?.ResolveIfRequired().Content
                .Any(x => x.Key.Contains("multipart/form-data")) == true,
            RequestType: requestType ?? TypeData.Default,
            ResponseType: responseType ?? TypeData.Default,
            AdditionalModels: [
                ..objectParameters,
                ..enumParameters,
                ..requestBodyModels,
                ..responseModels,
            ],
            AdditionalTypes: [
                ..requestBodyTypes,
                ..responseTypes,
            ],
            Converters: []);
        
        return endPoint;
    }
}