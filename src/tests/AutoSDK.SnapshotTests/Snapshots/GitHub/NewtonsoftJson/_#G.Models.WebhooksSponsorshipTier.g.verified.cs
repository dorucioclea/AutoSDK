﻿//HintName: G.Models.WebhooksSponsorshipTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `tier_changed` and `pending_tier_change` will include the original tier before the change or pending change. For more information, see the pending tier change payload.
    /// </summary>
    public sealed partial class WebhooksSponsorshipTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_custom_ammount")]
        public bool? IsCustomAmmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_custom_amount")]
        public bool? IsCustomAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_one_time", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOneTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int MonthlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthly_price_in_dollars", Required = global::Newtonsoft.Json.Required.Always)]
        public int MonthlyPriceInDollars { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorshipTier" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="isCustomAmmount"></param>
        /// <param name="isCustomAmount"></param>
        /// <param name="isOneTime"></param>
        /// <param name="monthlyPriceInCents"></param>
        /// <param name="monthlyPriceInDollars"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        public WebhooksSponsorshipTier(
            string createdAt,
            string description,
            bool isOneTime,
            int monthlyPriceInCents,
            int monthlyPriceInDollars,
            string name,
            string nodeId,
            bool? isCustomAmmount,
            bool? isCustomAmount)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsOneTime = isOneTime;
            this.MonthlyPriceInCents = monthlyPriceInCents;
            this.MonthlyPriceInDollars = monthlyPriceInDollars;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.IsCustomAmmount = isCustomAmmount;
            this.IsCustomAmount = isCustomAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorshipTier" /> class.
        /// </summary>
        public WebhooksSponsorshipTier()
        {
        }
    }
}