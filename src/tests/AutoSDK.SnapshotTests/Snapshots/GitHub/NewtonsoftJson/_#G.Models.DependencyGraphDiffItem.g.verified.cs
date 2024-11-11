﻿//HintName: G.Models.DependencyGraphDiffItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphDiffItemChangeType ChangeType { get; set; } = default!;

        /// <summary>
        /// Example: path/to/package-lock.json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Manifest { get; set; } = default!;

        /// <summary>
        /// Example: npm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ecosystem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ecosystem { get; set; } = default!;

        /// <summary>
        /// Example: @actions/core
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: 1.0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? PackageUrl { get; set; } = default!;

        /// <summary>
        /// Example: MIT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public string? License { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/github/actions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SourceRepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DependencyGraphDiffItemVulnerabilitie> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphDiffItemScope Scope { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItem" /> class.
        /// </summary>
        /// <param name="changeType"></param>
        /// <param name="manifest">
        /// Example: path/to/package-lock.json
        /// </param>
        /// <param name="ecosystem">
        /// Example: npm
        /// </param>
        /// <param name="name">
        /// Example: @actions/core
        /// </param>
        /// <param name="version">
        /// Example: 1.0.0
        /// </param>
        /// <param name="packageUrl">
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </param>
        /// <param name="license">
        /// Example: MIT
        /// </param>
        /// <param name="sourceRepositoryUrl">
        /// Example: https://github.com/github/actions
        /// </param>
        /// <param name="vulnerabilities"></param>
        /// <param name="scope">
        /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
        /// </param>
        public DependencyGraphDiffItem(
            global::G.DependencyGraphDiffItemChangeType changeType,
            string manifest,
            string ecosystem,
            string name,
            string version,
            string? packageUrl,
            string? license,
            string? sourceRepositoryUrl,
            global::System.Collections.Generic.IList<global::G.DependencyGraphDiffItemVulnerabilitie> vulnerabilities,
            global::G.DependencyGraphDiffItemScope scope)
        {
            this.ChangeType = changeType;
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Ecosystem = ecosystem ?? throw new global::System.ArgumentNullException(nameof(ecosystem));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.PackageUrl = packageUrl ?? throw new global::System.ArgumentNullException(nameof(packageUrl));
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.SourceRepositoryUrl = sourceRepositoryUrl ?? throw new global::System.ArgumentNullException(nameof(sourceRepositoryUrl));
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItem" /> class.
        /// </summary>
        public DependencyGraphDiffItem()
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
        public static global::G.DependencyGraphDiffItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependencyGraphDiffItem>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItem?>(serializer.Deserialize<global::G.DependencyGraphDiffItem>(jsonReader));
        }

    }
}