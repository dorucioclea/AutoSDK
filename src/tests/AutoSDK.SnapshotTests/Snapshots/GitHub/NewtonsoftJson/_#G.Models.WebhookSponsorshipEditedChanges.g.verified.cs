﻿//HintName: G.Models.WebhookSponsorshipEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSponsorshipEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy_level")]
        public global::G.WebhookSponsorshipEditedChangesPrivacyLevel? PrivacyLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSponsorshipEditedChanges" /> class.
        /// </summary>
        /// <param name="privacyLevel"></param>
        public WebhookSponsorshipEditedChanges(
            global::G.WebhookSponsorshipEditedChangesPrivacyLevel? privacyLevel)
        {
            this.PrivacyLevel = privacyLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSponsorshipEditedChanges" /> class.
        /// </summary>
        public WebhookSponsorshipEditedChanges()
        {
        }
    }
}