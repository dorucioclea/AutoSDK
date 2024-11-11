﻿//HintName: G.Models.PostApiReactivateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to re-activating API settings.
    /// </summary>
    public sealed partial class PostApiReactivateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiReactivateResponse" /> class.
        /// </summary>
        /// <param name="rechargeSettings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PostApiReactivateResponse(
            global::G.RechargeSettingsResponse? rechargeSettings)
        {
            this.RechargeSettings = rechargeSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiReactivateResponse" /> class.
        /// </summary>
        public PostApiReactivateResponse()
        {
        }
    }
}