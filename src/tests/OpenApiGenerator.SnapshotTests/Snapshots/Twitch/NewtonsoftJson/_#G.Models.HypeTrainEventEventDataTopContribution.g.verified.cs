﻿//HintName: G.Models.HypeTrainEventEventDataTopContribution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HypeTrainEventEventDataTopContribution
    {
        /// <summary>
        /// The total amount contributed. If `type` is BITS, `total` represents the amount of Bits used. If `type` is SUBS, `total` is 500, 1000, or 2500 to represent tier 1, 2, or 3 subscriptions, respectively.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The contribution method used. Possible values are:  <br/>
        ///   <br/>
        /// * BITS — Cheering with Bits.<br/>
        /// * SUBS — Subscription activity like subscribing or gifting subscriptions.<br/>
        /// * OTHER — Covers other contribution methods not listed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HypeTrainEventEventDataTopContributionType Type { get; set; } = default!;

        /// <summary>
        /// The ID of the user that made the contribution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public string User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}