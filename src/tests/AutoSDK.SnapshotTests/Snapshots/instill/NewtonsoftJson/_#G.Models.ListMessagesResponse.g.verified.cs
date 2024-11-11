﻿//HintName: G.Models.ListMessagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMessagesResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.AppV1alphaMessage>? Messages { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("senderProfiles")]
        public global::System.Collections.Generic.IList<global::G.MessageSenderProfile>? SenderProfiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesResponse" /> class.
        /// </summary>
        /// <param name="messages">
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Included only in responses
        /// </param>
        /// <param name="senderProfiles">
        /// Included only in responses
        /// </param>
        public ListMessagesResponse(
            global::System.Collections.Generic.IList<global::G.AppV1alphaMessage>? messages,
            string? nextPageToken,
            int? totalSize,
            global::System.Collections.Generic.IList<global::G.MessageSenderProfile>? senderProfiles)
        {
            this.Messages = messages;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
            this.SenderProfiles = senderProfiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesResponse" /> class.
        /// </summary>
        public ListMessagesResponse()
        {
        }
    }
}