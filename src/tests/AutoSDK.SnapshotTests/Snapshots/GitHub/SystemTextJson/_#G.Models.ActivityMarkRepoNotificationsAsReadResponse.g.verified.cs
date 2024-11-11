﻿//HintName: G.Models.ActivityMarkRepoNotificationsAsReadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityMarkRepoNotificationsAsReadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkRepoNotificationsAsReadResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActivityMarkRepoNotificationsAsReadResponse(
            string? message,
            string? url)
        {
            this.Message = message;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkRepoNotificationsAsReadResponse" /> class.
        /// </summary>
        public ActivityMarkRepoNotificationsAsReadResponse()
        {
        }
    }
}