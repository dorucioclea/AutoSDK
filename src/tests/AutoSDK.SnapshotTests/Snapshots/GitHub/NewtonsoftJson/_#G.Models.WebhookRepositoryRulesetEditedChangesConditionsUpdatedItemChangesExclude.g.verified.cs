﻿//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public global::System.Collections.Generic.IList<string>? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude(
            global::System.Collections.Generic.IList<string>? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude()
        {
        }
    }
}