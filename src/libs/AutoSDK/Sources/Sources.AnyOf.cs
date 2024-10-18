using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAnyOf(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var classNameWithoutTypes = string.IsNullOrWhiteSpace(anyOfData.Name)
            ? $"{anyOfData.SubType}"
            : anyOfData.Name;
        var className = string.IsNullOrWhiteSpace(anyOfData.Name)
            ? $"{anyOfData.SubType}{types}"
            : anyOfData.Name;
        var allTypes = anyOfData.Properties.IsEmpty
            ? Enumerable
                .Range(1, anyOfData.Count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                    },
                })
                .ToImmutableArray().AsEquatableArray()
            : anyOfData.Properties;
        var validation = anyOfData.SubType switch
        {
            "AnyOf" => string.Join(" || ", allTypes.Select(x => $"Is{x.Name}")),
            "OneOf" => string.Join(" || ", allTypes.Select((x, xi) =>
                string.Join(" && ", allTypes.Select((y, yi) => $"{(yi == xi ? "" : "!")}Is{y.Name}")))),
            "AllOf" => string.Join(" && ", allTypes.Select(x => $"Is{x.Name}")),
            _ => throw new NotImplementedException(),
        };
        var constructorWithAllValues =
            anyOfData.Count > 1 ||
            (!string.IsNullOrWhiteSpace(anyOfData.Name) &&
            anyOfData.DiscriminatorType != null &&
            anyOfData.DiscriminatorPropertyName != null &&
            allTypes.All(x => !string.IsNullOrWhiteSpace(x.DiscriminatorValue))) ? $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}(
{(string.IsNullOrWhiteSpace(anyOfData.Name) ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  allTypes.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
            {anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}? {anyOfData.DiscriminatorPropertyName.ToParameterName()},
 ")}
{allTypes.Select(x => $@" 
            {x.Type.CSharpTypeWithNullability} {x.ParameterName},
").Inject().TrimEnd(',', '\n')}
            )
        {{
{(string.IsNullOrWhiteSpace(anyOfData.Name) ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  allTypes.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
            {anyOfData.DiscriminatorPropertyName} = {anyOfData.DiscriminatorPropertyName.ToParameterName()};
")}
{allTypes.Select(x => $@" 
            {x.Name} = {x.ParameterName};
").Inject()}
        }}" : " ";
        var json = GenerateFromToJsonMethods(anyOfData.Namespace, className, anyOfData.Settings, isValueType: true, cancellationToken);
        
        return $@"using System.Linq;
{(anyOfData.Properties.IsEmpty ? "" : @"#pragma warning disable CS0618 // Type or member is obsolete
")}
#nullable enable

namespace {anyOfData.Namespace}
{{
    {anyOfData.Summary.ToXmlDocumentationSummary(level: 4)}
    public readonly partial struct {className} : global::System.IEquatable<{className}>
    {{
{(string.IsNullOrWhiteSpace(anyOfData.Name) ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  allTypes.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}? {anyOfData.DiscriminatorPropertyName} {{ get; }}
")}
{allTypes.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; init; }}
#else
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; }}
#endif

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof({x.Name}))]
#endif
        public bool Is{x.Name} => {x.Name} != null;
{(className != x.Type.CSharpTypeWithoutNullability && x.Type.CSharpTypeWithoutNullability.StartsWith("global::System.Collections.Generic.IList", StringComparison.Ordinal) != true ? $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {className}({x.Type.CSharpTypeWithoutNullability} value) => new {className}(value);

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {x.Type.CSharpTypeWithNullability}({className} @this) => @this.{x.Name};
 " : " ")}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}({x.Type.CSharpTypeWithNullability} value)
        {{
            {x.Name} = value;
        }}
").Inject()}
{constructorWithAllValues}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public object? Object =>
{allTypes.Reverse().Select(x => $@" 
            {x.Name} as object ??
").Inject().TrimEnd('?', '\n')}
            ;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Validate()
        {{
            return {validation};
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public TResult? Match<TResult>(
{allTypes.Select(x => $@" 
            global::System.Func<{x.Type.CSharpType}, TResult>? {x.ParameterName} = null,
").Inject()}
            bool validate = true)
        {{
            if (validate)
            {{
                Validate();
            }}

{allTypes.Select((x, i) => $@"
            {(i > 0 ? "else " : "")}if (Is{x.Name} && {x.ParameterName} != null)
            {{
                return {x.ParameterName}({x.Name}!);
            }}").Inject()}

            return default(TResult);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public void Match(
{allTypes.Select(x => $@" 
            global::System.Action<{x.Type.CSharpType}>? {x.ParameterName} = null,
").Inject()}
            bool validate = true)
        {{
            if (validate)
            {{
                Validate();
            }}

{allTypes.Select((x, i) => $@"
            {(i > 0 ? "else " : "")}if (Is{x.Name})
            {{
                {x.ParameterName}?.Invoke({x.Name}!);
            }}").Inject()}
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override int GetHashCode()
        {{
            var fields = new object?[]
            {{
{allTypes.Select(x => $@" 
                {x.Name},
                typeof({x.Type.CSharpTypeWithoutNullability}),
").Inject()}
            }};
            
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
    
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
    
            return fields.Aggregate(offset, HashCodeAggregator);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Equals({className} other)
        {{
            return
{allTypes.Select(x => $@" 
                global::System.Collections.Generic.EqualityComparer<{x.Type.CSharpTypeWithNullability}>.Default.Equals({x.Name}, other.{x.Name}) &&
").Inject().TrimEnd('&', '\n')}
                ;
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator ==({className} obj1, {className} obj2)
        {{
            return global::System.Collections.Generic.EqualityComparer<{className}>.Default.Equals(obj1, obj2);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator !=({className} obj1, {className} obj2)
        {{
            return !(obj1 == obj2);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override bool Equals(object? obj)
        {{
            return obj is {className} o && Equals(o);
        }}

{json}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}