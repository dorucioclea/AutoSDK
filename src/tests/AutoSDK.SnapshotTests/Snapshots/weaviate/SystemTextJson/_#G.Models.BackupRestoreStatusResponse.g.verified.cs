﻿//HintName: G.Models.BackupRestoreStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of a backup restore metadata
    /// </summary>
    public sealed partial class BackupRestoreStatusResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// destination path of backup files proper to selected backup backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if restoration failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup restoration process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BackupRestoreStatusResponseStatusJsonConverter))]
        public global::G.BackupRestoreStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreStatusResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="backend">
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </param>
        /// <param name="path">
        /// destination path of backup files proper to selected backup backend
        /// </param>
        /// <param name="error">
        /// error message if restoration failed
        /// </param>
        /// <param name="status">
        /// phase of backup restoration process<br/>
        /// Default Value: STARTED
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupRestoreStatusResponse(
            string? id,
            string? backend,
            string? path,
            string? error,
            global::G.BackupRestoreStatusResponseStatus? status)
        {
            this.Id = id;
            this.Backend = backend;
            this.Path = path;
            this.Error = error;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreStatusResponse" /> class.
        /// </summary>
        public BackupRestoreStatusResponse()
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
        public static global::G.BackupRestoreStatusResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BackupRestoreStatusResponse),
                jsonSerializerContext) as global::G.BackupRestoreStatusResponse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BackupRestoreStatusResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BackupRestoreStatusResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.BackupRestoreStatusResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.BackupRestoreStatusResponse),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.BackupRestoreStatusResponse;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.BackupRestoreStatusResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.BackupRestoreStatusResponse?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}