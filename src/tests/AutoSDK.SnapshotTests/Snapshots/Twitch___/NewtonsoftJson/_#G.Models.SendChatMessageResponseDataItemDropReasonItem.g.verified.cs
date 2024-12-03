﻿//HintName: G.Models.SendChatMessageResponseDataItemDropReasonItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageResponseDataItemDropReasonItem
    {
        /// <summary>
        /// Code for why the message was dropped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Message for why the message was dropped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItemDropReasonItem" /> class.
        /// </summary>
        /// <param name="code">
        /// Code for why the message was dropped.
        /// </param>
        /// <param name="message">
        /// Message for why the message was dropped.
        /// </param>
        public SendChatMessageResponseDataItemDropReasonItem(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItemDropReasonItem" /> class.
        /// </summary>
        public SendChatMessageResponseDataItemDropReasonItem()
        {
        }
    }
}