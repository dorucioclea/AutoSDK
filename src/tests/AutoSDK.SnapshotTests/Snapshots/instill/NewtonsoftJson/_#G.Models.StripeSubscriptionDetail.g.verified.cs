﻿//HintName: G.Models.StripeSubscriptionDetail.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// StripeSubscriptionDetail describes the details of a subscription in Stripe.
    /// </summary>
    public sealed partial class StripeSubscriptionDetail
    {
        /// <summary>
        /// Product name associated with the subscription in Stripe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("productName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// Unique identifier for the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier for the specific item within the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Price of the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>
        /// Optional timestamp indicating when the subscription was canceled, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canceledAt")]
        public int CanceledAt { get; set; }

        /// <summary>
        /// Optional timestamp indicating when the trial ended, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trialEnd")]
        public int TrialEnd { get; set; }

        /// <summary>
        /// Status of the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.AllOf<global::G.StripeSubscriptionDetailStatus?>? Status { get; set; }

        /// <summary>
        /// Description of the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}