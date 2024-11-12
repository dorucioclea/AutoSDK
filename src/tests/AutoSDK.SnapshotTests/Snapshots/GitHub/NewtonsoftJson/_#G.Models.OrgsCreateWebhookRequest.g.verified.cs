﻿//HintName: G.Models.OrgsCreateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateWebhookRequest
    {
        /// <summary>
        /// Must be passed as "web".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Key/value pairs to provide settings for this webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgsCreateWebhookRequestConfig Config { get; set; } = default!;

        /// <summary>
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. Set to `["*"]` to receive all possible events.<br/>
        /// Default Value: [push]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Must be passed as "web".
        /// </param>
        /// <param name="config">
        /// Key/value pairs to provide settings for this webhook.
        /// </param>
        /// <param name="events">
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. Set to `["*"]` to receive all possible events.<br/>
        /// Default Value: [push]
        /// </param>
        /// <param name="active">
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </param>
        public OrgsCreateWebhookRequest(
            string name,
            global::G.OrgsCreateWebhookRequestConfig config,
            global::System.Collections.Generic.IList<string>? events,
            bool? active)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Events = events;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateWebhookRequest" /> class.
        /// </summary>
        public OrgsCreateWebhookRequest()
        {
        }
    }
}