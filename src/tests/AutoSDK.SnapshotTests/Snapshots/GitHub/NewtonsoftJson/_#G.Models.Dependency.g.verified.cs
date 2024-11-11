﻿//HintName: G.Models.Dependency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dependency
    {
        /// <summary>
        /// Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.<br/>
        /// Example: pkg:/npm/%40actions/http-client@1.0.11
        /// </summary>
        /// <example>pkg:/npm/%40actions/http-client@1.0.11</example>
        [global::Newtonsoft.Json.JsonProperty("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
        /// Example: direct
        /// </summary>
        /// <example>direct</example>
        [global::Newtonsoft.Json.JsonProperty("relationship")]
        public global::G.DependencyRelationship? Relationship { get; set; }

        /// <summary>
        /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
        /// Example: runtime
        /// </summary>
        /// <example>runtime</example>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.DependencyScope? Scope { get; set; }

        /// <summary>
        /// Array of package-url (PURLs) of direct child dependencies.<br/>
        /// Example: @actions/http-client
        /// </summary>
        /// <example>@actions/http-client</example>
        [global::Newtonsoft.Json.JsonProperty("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        /// <param name="packageUrl">
        /// Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.<br/>
        /// Example: pkg:/npm/%40actions/http-client@1.0.11
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="relationship">
        /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
        /// Example: direct
        /// </param>
        /// <param name="scope">
        /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
        /// Example: runtime
        /// </param>
        /// <param name="dependencies">
        /// Array of package-url (PURLs) of direct child dependencies.<br/>
        /// Example: @actions/http-client
        /// </param>
        public Dependency(
            string? packageUrl,
            object? metadata,
            global::G.DependencyRelationship? relationship,
            global::G.DependencyScope? scope,
            global::System.Collections.Generic.IList<string>? dependencies)
        {
            this.PackageUrl = packageUrl;
            this.Metadata = metadata;
            this.Relationship = relationship;
            this.Scope = scope;
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        public Dependency()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Dependency? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Dependency>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Dependency?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Dependency?>(serializer.Deserialize<global::G.Dependency>(jsonReader));
        }

    }
}