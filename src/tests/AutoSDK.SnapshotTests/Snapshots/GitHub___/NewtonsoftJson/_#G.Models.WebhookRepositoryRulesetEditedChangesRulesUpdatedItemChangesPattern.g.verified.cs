﻿//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern(
            string? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern()
        {
        }
    }
}