﻿//HintName: G.Models.GetOrganizationSubscriptionResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetOrganizationSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetOrganizationSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription")]
        public global::G.AllOf<global::G.OrganizationSubscription>? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}