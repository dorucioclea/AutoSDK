﻿//HintName: G.Models.UpdateConduitShardsResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseError
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The error that occurred while updating the shard. Possible errors:  <br/>
        ///   <br/>
        /// * The length of the string in the secret field is not valid.<br/>
        /// * The URL in the transport's callback field is not valid. The URL must use the HTTPS protocol and the 443 port number.<br/>
        /// * The value specified in the method field is not valid.<br/>
        /// * The callback field is required if you specify the webhook transport method.<br/>
        /// * The session\_id field is required if you specify the WebSocket transport method.<br/>
        /// * The websocket session is not connected.<br/>
        /// * The shard id is outside of the conduit’s range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Error codes used to represent a specific error condition while attempting to update shards.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseError" /> class.
        /// </summary>
        /// <param name="id">
        /// Shard ID.
        /// </param>
        /// <param name="message">
        /// The error that occurred while updating the shard. Possible errors:  <br/>
        ///   <br/>
        /// * The length of the string in the secret field is not valid.<br/>
        /// * The URL in the transport's callback field is not valid. The URL must use the HTTPS protocol and the 443 port number.<br/>
        /// * The value specified in the method field is not valid.<br/>
        /// * The callback field is required if you specify the webhook transport method.<br/>
        /// * The session\_id field is required if you specify the WebSocket transport method.<br/>
        /// * The websocket session is not connected.<br/>
        /// * The shard id is outside of the conduit’s range.
        /// </param>
        /// <param name="code">
        /// Error codes used to represent a specific error condition while attempting to update shards.
        /// </param>
        public UpdateConduitShardsResponseError(
            string id,
            string message,
            string code)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseError" /> class.
        /// </summary>
        public UpdateConduitShardsResponseError()
        {
        }
    }
}