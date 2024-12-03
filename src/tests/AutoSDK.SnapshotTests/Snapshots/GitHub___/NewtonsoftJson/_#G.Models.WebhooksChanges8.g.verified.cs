﻿//HintName: G.Models.WebhooksChanges8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksChanges8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksChanges8Tier Tier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksChanges8" /> class.
        /// </summary>
        /// <param name="tier"></param>
        public WebhooksChanges8(
            global::G.WebhooksChanges8Tier tier)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksChanges8" /> class.
        /// </summary>
        public WebhooksChanges8()
        {
        }
    }
}