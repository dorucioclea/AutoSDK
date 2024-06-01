﻿//HintName: G.Models.OrgsUpdateWebhookConfigForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdateWebhookConfigForOrgRequest
    {
        /// <summary>
        /// The URL to which the payloads will be delivered.
        /// <br/>Example: https://example.com/webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.
        /// <br/>Example: "json"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).
        /// <br/>Example: "********"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insecure_ssl")]
        public global::System.OneOf<string?, double> InsecureSsl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}