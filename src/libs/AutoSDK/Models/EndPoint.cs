using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Naming.Clients;
using AutoSDK.Serialization.Form;

namespace AutoSDK.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    bool Stream,
    string Path,
    string RequestMediaType,
    ImmutableArray<MethodParameter> Parameters,
    ImmutableArray<Authorization> Authorizations,
    ImmutableArray<MethodParameter> QueryParameters,
    OperationType HttpMethod,
    ContentType ContentType,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    bool IsDeprecated,
    TypeData RequestType,
    TypeData ResponseType
)
{
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";
    
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.{Id.ToPropertyName()}";
    
    public string InterfaceFileNameWithoutExtension => $"{Namespace}.I{ClassName}.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var authorizations = operation.Operation.Security
            .SelectMany(x => x)
            .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings))
            .ToImmutableArray();
        if (authorizations.Length == 0)
        {
            authorizations = operation.GlobalSecurityRequirements
                .SelectMany(x => x)
                .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings))
                .ToImmutableArray();
        }
        
        var parameters = operation.Schemas
            .Where(x => x is { Hint: Hint.Parameter, ParameterData: not null })
            .Select(x => x.ParameterData!.Value)
            .ToList();
        
        // Ensure that parameters with the same name are unique
        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Count; i++)
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
        
        var preparedPath = operation.OperationPath.PreparePath(parameters);
        var queryParameters = ParameterSerializer.SerializeQueryParameters(parameters);
 
        var requestMediaTypes =
            operation.Operation.RequestBody?.ResolveIfRequired().Content ??
            new Dictionary<string, OpenApiMediaType>();

        var requestContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Request);
        TypeData? requestType = requestContext?.TypeData;
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";
        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }

        var responses = (operation.Operation.Responses ?? [])
            .SelectMany(x => x.Value?.ResolveIfRequired().Content?.Select(y => (Response: x, MediaType: y)) ?? [])
            .ToArray();
        var contentType = responses
            .Any(x => x.MediaType.Key.Contains("application/octet-stream"))
            ? ContentType.ByteArray
            : ContentType.String;
        var responseContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Response);
        TypeData? responseType = contentType switch
        {
            ContentType.ByteArray => TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
            },
            _ => responseContext?.TypeData,
        };

        foreach (var requestProperty in requestContext?.ResolvedReference?.ClassData?.Properties ??
                                        requestContext?.ClassData?.Properties ??
                                        [])
        {
            if (requestProperty.IsReadOnly)
            {
                continue;
            }
            
            parameters.Add(MethodParameter.Default with
            {
                Id = requestProperty.Id,
                Name = parameters.All(x => x.Name != requestProperty.Name)
                    ? requestProperty.Name
                    : $"request{requestProperty.Name.ToPropertyName()}",
                Type = requestProperty.Type with
                {
                    CSharpTypeNullability =
                        requestProperty.Type.IsNullable ||
                        (requestProperty.Type.CSharpTypeNullability && !requestProperty.IsRequired && !requestProperty.IsWriteOnly),
                },
                IsRequired = requestProperty.IsRequired || requestProperty.IsWriteOnly,
                IsMultiPartFormDataFilename = requestProperty.IsMultiPartFormDataFilename,
                DefaultValue = requestProperty.DefaultValue,
                IsDeprecated = requestProperty.IsDeprecated,
                Settings = requestProperty.Settings,
                Summary = requestProperty.Summary,
                ConverterType = requestProperty.ConverterType,
            });
        }
        
        var firstTag = (operation.Operation.Tags ?? []).FirstOrDefault();
        var endPoint = new EndPoint(
            Id: operation.MethodName,
            Namespace: operation.Settings.Namespace,
            ClassName: operation.Settings.GroupByTags && firstTag != null
                ? ClientNameGenerator.Generate(operation.Settings, firstTag)
                : operation.Settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: responses
                .Any(x => x.MediaType.Key.Contains("application/x-ndjson")), // text/event-stream
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Parameters: parameters.ToImmutableArray(),
            QueryParameters: queryParameters.ToImmutableArray(),
            Authorizations: authorizations,
            HttpMethod: operation.OperationType,
            ContentType: contentType,
            Summary: operation.Operation.GetXmlDocumentationSummary(),
            BaseUrlSummary: string.Empty,
            Settings: operation.Settings,
            IsDeprecated: operation.Operation.Deprecated,
            RequestType: requestType ?? TypeData.Default,
            ResponseType: responseType ?? TypeData.Default);
        
        return endPoint;
    }
}