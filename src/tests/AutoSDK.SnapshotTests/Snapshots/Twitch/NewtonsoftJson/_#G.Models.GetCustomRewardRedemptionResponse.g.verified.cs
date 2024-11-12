﻿//HintName: G.Models.GetCustomRewardRedemptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCustomRewardRedemptionResponse
    {
        /// <summary>
        /// The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomRewardRedemptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.
        /// </param>
        public GetCustomRewardRedemptionResponse(
            global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomRewardRedemptionResponse" /> class.
        /// </summary>
        public GetCustomRewardRedemptionResponse()
        {
        }
    }
}