﻿//HintName: G.Models.UpdateConduitShardsResponseDataItemTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details used to send the notifications.
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseDataItemTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateConduitShardsResponseDataItemTransportMethod Method { get; set; } = default!;

        /// <summary>
        /// The callback URL where the notifications are sent. Included only if method is set to webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnected_at")]
        public global::System.DateTime? DisconnectedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItemTransport" /> class.
        /// </summary>
        /// <param name="method">
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket
        /// </param>
        /// <param name="callback">
        /// The callback URL where the notifications are sent. Included only if method is set to webhook.
        /// </param>
        /// <param name="sessionId">
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.
        /// </param>
        /// <param name="connectedAt">
        /// The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.
        /// </param>
        /// <param name="disconnectedAt">
        /// The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.
        /// </param>
        public UpdateConduitShardsResponseDataItemTransport(
            global::G.UpdateConduitShardsResponseDataItemTransportMethod method,
            string? callback,
            string? sessionId,
            global::System.DateTime? connectedAt,
            global::System.DateTime? disconnectedAt)
        {
            this.Method = method;
            this.Callback = callback;
            this.SessionId = sessionId;
            this.ConnectedAt = connectedAt;
            this.DisconnectedAt = disconnectedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItemTransport" /> class.
        /// </summary>
        public UpdateConduitShardsResponseDataItemTransport()
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
        public static global::G.UpdateConduitShardsResponseDataItemTransport? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateConduitShardsResponseDataItemTransport>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.UpdateConduitShardsResponseDataItemTransport?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.UpdateConduitShardsResponseDataItemTransport?>(serializer.Deserialize<global::G.UpdateConduitShardsResponseDataItemTransport>(jsonReader));
        }

    }
}