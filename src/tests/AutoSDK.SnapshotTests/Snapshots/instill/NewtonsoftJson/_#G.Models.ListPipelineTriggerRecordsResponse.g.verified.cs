﻿//HintName: G.Models.ListPipelineTriggerRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineTriggerRecordsResponse contains a list of pipeline triggers.
    /// </summary>
    public sealed partial class ListPipelineTriggerRecordsResponse
    {
        /// <summary>
        /// A list of pipeline triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineTriggerRecords")]
        public global::System.Collections.Generic.IList<global::G.PipelineTriggerRecord>? PipelineTriggerRecords { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipeline triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerRecordsResponse" /> class.
        /// </summary>
        /// <param name="pipelineTriggerRecords">
        /// A list of pipeline triggers.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipeline triggers.
        /// </param>
        public ListPipelineTriggerRecordsResponse(
            global::System.Collections.Generic.IList<global::G.PipelineTriggerRecord>? pipelineTriggerRecords,
            string? nextPageToken,
            int? totalSize)
        {
            this.PipelineTriggerRecords = pipelineTriggerRecords;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerRecordsResponse" /> class.
        /// </summary>
        public ListPipelineTriggerRecordsResponse()
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
        public static global::G.ListPipelineTriggerRecordsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListPipelineTriggerRecordsResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListPipelineTriggerRecordsResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListPipelineTriggerRecordsResponse?>(serializer.Deserialize<global::G.ListPipelineTriggerRecordsResponse>(jsonReader));
        }

    }
}