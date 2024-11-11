﻿//HintName: G.Models.CodespaceExportDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An export of a codespace. Also, latest export details for a codespace can be fetched with id = latest
    /// </summary>
    public sealed partial class CodespaceExportDetails
    {
        /// <summary>
        /// State of the latest export<br/>
        /// Example: succeeded | failed | in_progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Completion time of the last export operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Name of the exported branch<br/>
        /// Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Git commit SHA of the exported branch<br/>
        /// Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Id for the export details<br/>
        /// Example: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Url for fetching export details<br/>
        /// Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_url")]
        public string? ExportUrl { get; set; }

        /// <summary>
        /// Web url for the exported branch<br/>
        /// Example: https://github.com/octocat/hello-world/tree/:branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceExportDetails" /> class.
        /// </summary>
        /// <param name="state">
        /// State of the latest export<br/>
        /// Example: succeeded | failed | in_progress
        /// </param>
        /// <param name="completedAt">
        /// Completion time of the last export operation
        /// </param>
        /// <param name="branch">
        /// Name of the exported branch<br/>
        /// Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </param>
        /// <param name="sha">
        /// Git commit SHA of the exported branch<br/>
        /// Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </param>
        /// <param name="id">
        /// Id for the export details<br/>
        /// Example: latest
        /// </param>
        /// <param name="exportUrl">
        /// Url for fetching export details<br/>
        /// Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </param>
        /// <param name="htmlUrl">
        /// Web url for the exported branch<br/>
        /// Example: https://github.com/octocat/hello-world/tree/:branch
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespaceExportDetails(
            string? state,
            global::System.DateTime? completedAt,
            string? branch,
            string? sha,
            string? id,
            string? exportUrl,
            string? htmlUrl)
        {
            this.State = state;
            this.CompletedAt = completedAt;
            this.Branch = branch;
            this.Sha = sha;
            this.Id = id;
            this.ExportUrl = exportUrl;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceExportDetails" /> class.
        /// </summary>
        public CodespaceExportDetails()
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
        public static global::G.CodespaceExportDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CodespaceExportDetails),
                jsonSerializerContext) as global::G.CodespaceExportDetails;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodespaceExportDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodespaceExportDetails>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CodespaceExportDetails?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CodespaceExportDetails),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CodespaceExportDetails;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespaceExportDetails?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CodespaceExportDetails?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}