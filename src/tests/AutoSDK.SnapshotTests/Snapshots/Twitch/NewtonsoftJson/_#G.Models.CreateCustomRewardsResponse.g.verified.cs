﻿//HintName: G.Models.CreateCustomRewardsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomRewardsResponse
    {
        /// <summary>
        /// A list that contains the single custom reward you created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomReward> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomRewardsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single custom reward you created.
        /// </param>
        public CreateCustomRewardsResponse(
            global::System.Collections.Generic.IList<global::G.CustomReward> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomRewardsResponse" /> class.
        /// </summary>
        public CreateCustomRewardsResponse()
        {
        }
    }
}