﻿//HintName: G.Models.Artifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An artifact
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the artifact.<br/>
        /// Example: AdventureWorks.Framework
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The size in bytes of the artifact.<br/>
        /// Example: 12345
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeInBytes { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArchiveDownloadUrl { get; set; }

        /// <summary>
        /// Whether or not the artifact has expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Expired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run")]
        public global::G.ArtifactWorkflowRun? WorkflowRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 5
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: AdventureWorks.Framework
        /// </param>
        /// <param name="sizeInBytes">
        /// The size in bytes of the artifact.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5
        /// </param>
        /// <param name="archiveDownloadUrl">
        /// Example: https://api.github.com/repos/github/hello-world/actions/artifacts/5/zip
        /// </param>
        /// <param name="expired">
        /// Whether or not the artifact has expired.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="workflowRun"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Artifact(
            int id,
            string nodeId,
            string name,
            int sizeInBytes,
            string url,
            string archiveDownloadUrl,
            bool expired,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt,
            global::System.DateTime? updatedAt,
            global::G.ArtifactWorkflowRun? workflowRun)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SizeInBytes = sizeInBytes;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ArchiveDownloadUrl = archiveDownloadUrl ?? throw new global::System.ArgumentNullException(nameof(archiveDownloadUrl));
            this.Expired = expired;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.UpdatedAt = updatedAt;
            this.WorkflowRun = workflowRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
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
        public static global::G.Artifact? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Artifact),
                jsonSerializerContext) as global::G.Artifact;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Artifact? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Artifact>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Artifact?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Artifact),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Artifact;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Artifact?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Artifact?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}