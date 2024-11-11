﻿//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem
    {
        /// <summary>
        /// Parameters for a repository ruleset ref name condition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public global::G.RepositoryRulesetConditions? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem" /> class.
        /// </summary>
        /// <param name="condition">
        /// Parameters for a repository ruleset ref name condition
        /// </param>
        /// <param name="changes"></param>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem(
            global::G.RepositoryRulesetConditions? condition,
            global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges? changes)
        {
            this.Condition = condition;
            this.Changes = changes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem()
        {
        }
    }
}