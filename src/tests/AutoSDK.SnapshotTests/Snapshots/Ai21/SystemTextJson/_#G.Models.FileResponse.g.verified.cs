﻿//HintName: G.Models.FileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// The unique identifier of the file, generated by AI21.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// The name of the file. This is the local file name from when the file was<br/>
        /// uploaded. It cannot be modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An arbitrary file-path-like string to indicate the content of a file. This has<br/>
        /// nothing to do with the location of the file in storage or on disk, and is only<br/>
        /// another label that you can assign to the file in path-like format to help you<br/>
        /// organize the contents of the file or filter queries against your files. Example<br/>
        /// paths might be `pets/fish` or `pets/dogs`. Then, when searching your library,<br/>
        /// you can filter files by the full path or path prefix. So to search only files<br/>
        /// in the "dog folder", filter by the path `/pets/dogs`. To search all files in<br/>
        /// the "pet folder", filter your search by the path `pets/` when searching by path.<br/>
        /// There isn't a restriction on whether a path must start or end with a / mark, but<br/>
        /// be consistent in your usage, and all matches are prefix matching, not substring<br/>
        /// matching. So filtering by `dog/` matches `dog/` and `dog/setter` but not `pets/dog/`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The file type. See the file upload method to learn what file types are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileType { get; set; }

        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// Any string labels you have associated with the file. You can apply arbitrary<br/>
        /// string labels to your files and limit queries to files with one or more labels.<br/>
        /// Similar to paths, but labels do not prefix match. Labels are case-sensitive.<br/>
        /// There can be a maximum of 20 unique labels per account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// An internal identifier of the user who uploaded the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatedBy { get; set; }

        /// <summary>
        /// The date when the file was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationDate { get; set; }

        /// <summary>
        /// When the file data or metadata was last changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        /// File status. One of the following values: "DB_RECORD_CREATED",<br/>
        /// "UPLOADED", "UPLOAD_FAILED", "PROCESSED", "PROCESSING_FAILED"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.FileResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.FileResponse),
                jsonSerializerContext) as global::G.FileResponse;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FileResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}