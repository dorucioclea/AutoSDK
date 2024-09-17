﻿//HintName: G.Models.OrganizationSubscription.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// OrganizationSubscription details describe the plan (i.e., features) an organization has access to.
    /// </summary>
    public sealed partial class OrganizationSubscription
    {
        /// <summary>
        /// Plan identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.OrganizationSubscriptionPlan?>? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.StripeSubscriptionDetail>? Detail { get; set; }

        /// <summary>
        /// Number of used seats within the organization subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedSeats")]
        public int UsedSeats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}