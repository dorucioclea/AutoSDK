﻿//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update the source for the repository. Must include the branch name and path.
    /// </summary>
    public sealed partial class ReposUpdateInformationAboutPagesSiteRequestSourceEnum2
    {
        /// <summary>
        /// The repository branch used to publish your site's source files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPathJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequestSourceEnum2" /> class.
        /// </summary>
        /// <param name="branch">
        /// The repository branch used to publish your site's source files.
        /// </param>
        /// <param name="path">
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateInformationAboutPagesSiteRequestSourceEnum2(
            string branch,
            global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath path)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequestSourceEnum2" /> class.
        /// </summary>
        public ReposUpdateInformationAboutPagesSiteRequestSourceEnum2()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2),
                jsonSerializerContext) as global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}