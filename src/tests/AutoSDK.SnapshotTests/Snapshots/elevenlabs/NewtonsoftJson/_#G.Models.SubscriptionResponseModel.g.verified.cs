﻿//HintName: G.Models.SubscriptionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tier { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_extend_character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_to_extend_character_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowedToExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_character_count_reset_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int NextCharacterCountResetUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int VoiceLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_voice_add_edits", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxVoiceAddEdits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_add_edit_counter", Required = global::Newtonsoft.Json.Required.Always)]
        public int VoiceAddEditCounter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("professional_voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProfessionalVoiceLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_extend_voice_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanExtendVoiceLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_instant_voice_cloning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseInstantVoiceCloning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_professional_voice_cloning", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanUseProfessionalVoiceCloning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModelCurrency Currency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_period", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModelBillingPeriod BillingPeriod { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_refresh_period", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SubscriptionResponseModelCharacterRefreshPeriod CharacterRefreshPeriod { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}