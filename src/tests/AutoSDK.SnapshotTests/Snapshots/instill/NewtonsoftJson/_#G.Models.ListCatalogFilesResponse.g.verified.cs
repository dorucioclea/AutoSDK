﻿//HintName: G.Models.ListCatalogFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCatalogFilesResponse
    {
        /// <summary>
        /// The list of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.File> Files { get; set; } = default!;

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.ListCatalogFilesFilter? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The list of files.
        /// </param>
        /// <param name="totalSize">
        /// The total number of files.
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.
        /// </param>
        /// <param name="nextPageToken"></param>
        /// <param name="filter">
        /// The filter.
        /// </param>
        public ListCatalogFilesResponse(
            global::System.Collections.Generic.IList<global::G.File> files,
            int? totalSize,
            int? pageSize,
            string? nextPageToken,
            global::G.ListCatalogFilesFilter? filter)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.NextPageToken = nextPageToken;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogFilesResponse" /> class.
        /// </summary>
        public ListCatalogFilesResponse()
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
        public static global::G.ListCatalogFilesResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListCatalogFilesResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListCatalogFilesResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListCatalogFilesResponse?>(serializer.Deserialize<global::G.ListCatalogFilesResponse>(jsonReader));
        }

    }
}