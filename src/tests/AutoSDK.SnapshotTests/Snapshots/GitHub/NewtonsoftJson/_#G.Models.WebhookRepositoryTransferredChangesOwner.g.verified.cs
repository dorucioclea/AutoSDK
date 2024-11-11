﻿//HintName: G.Models.WebhookRepositoryTransferredChangesOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryTransferredChangesOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookRepositoryTransferredChangesOwnerFrom From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwner" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookRepositoryTransferredChangesOwner(
            global::G.WebhookRepositoryTransferredChangesOwnerFrom from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwner" /> class.
        /// </summary>
        public WebhookRepositoryTransferredChangesOwner()
        {
        }
    }
}