﻿//HintName: G.Models.VectorStoreFileBatchObjectFileCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreFileBatchObjectFileCounts
    {
        /// <summary>
        /// The number of files that are currently being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public int InProgress { get; set; } = default!;

        /// <summary>
        /// The number of files that have been processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Completed { get; set; } = default!;

        /// <summary>
        /// The number of files that have failed to process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// The number of files that where cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cancelled { get; set; } = default!;

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObjectFileCounts" /> class.
        /// </summary>
        /// <param name="inProgress">
        /// The number of files that are currently being processed.
        /// </param>
        /// <param name="completed">
        /// The number of files that have been processed.
        /// </param>
        /// <param name="failed">
        /// The number of files that have failed to process.
        /// </param>
        /// <param name="cancelled">
        /// The number of files that where cancelled.
        /// </param>
        /// <param name="total">
        /// The total number of files.
        /// </param>
        public VectorStoreFileBatchObjectFileCounts(
            int inProgress,
            int completed,
            int failed,
            int cancelled,
            int total)
        {
            this.InProgress = inProgress;
            this.Completed = completed;
            this.Failed = failed;
            this.Cancelled = cancelled;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObjectFileCounts" /> class.
        /// </summary>
        public VectorStoreFileBatchObjectFileCounts()
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
        public static global::G.VectorStoreFileBatchObjectFileCounts? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.VectorStoreFileBatchObjectFileCounts>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.VectorStoreFileBatchObjectFileCounts?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.VectorStoreFileBatchObjectFileCounts?>(serializer.Deserialize<global::G.VectorStoreFileBatchObjectFileCounts>(jsonReader));
        }

    }
}