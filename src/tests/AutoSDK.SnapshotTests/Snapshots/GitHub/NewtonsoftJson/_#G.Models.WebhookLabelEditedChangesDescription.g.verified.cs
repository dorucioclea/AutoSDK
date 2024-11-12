﻿//HintName: G.Models.WebhookLabelEditedChangesDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLabelEditedChangesDescription
    {
        /// <summary>
        /// The previous version of the description if the action was `edited`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChangesDescription" /> class.
        /// </summary>
        /// <param name="from">
        /// The previous version of the description if the action was `edited`.
        /// </param>
        public WebhookLabelEditedChangesDescription(
            string from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChangesDescription" /> class.
        /// </summary>
        public WebhookLabelEditedChangesDescription()
        {
        }
    }
}