﻿//HintName: G.Models.BatchMessageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An individual message request within a batch.
    /// </summary>
    public sealed partial class BatchMessageRequest
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for<br/>
        /// matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomId { get; set; } = default!;

        /// <summary>
        /// The request parameters for creating a message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMessageRequest Params { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessageRequest" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for<br/>
        /// matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </param>
        /// <param name="params">
        /// The request parameters for creating a message.
        /// </param>
        public BatchMessageRequest(
            string customId,
            global::G.CreateMessageRequest @params)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMessageRequest" /> class.
        /// </summary>
        public BatchMessageRequest()
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
        public static global::G.BatchMessageRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BatchMessageRequest>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BatchMessageRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BatchMessageRequest?>(serializer.Deserialize<global::G.BatchMessageRequest>(jsonReader));
        }

    }
}