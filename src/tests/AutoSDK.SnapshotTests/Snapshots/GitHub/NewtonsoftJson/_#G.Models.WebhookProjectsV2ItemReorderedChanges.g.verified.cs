﻿//HintName: G.Models.WebhookProjectsV2ItemReorderedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemReorderedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_projects_v2_item_node_id")]
        public global::G.WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId? PreviousProjectsV2ItemNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemReorderedChanges" /> class.
        /// </summary>
        /// <param name="previousProjectsV2ItemNodeId"></param>
        public WebhookProjectsV2ItemReorderedChanges(
            global::G.WebhookProjectsV2ItemReorderedChangesPreviousProjectsV2ItemNodeId? previousProjectsV2ItemNodeId)
        {
            this.PreviousProjectsV2ItemNodeId = previousProjectsV2ItemNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemReorderedChanges" /> class.
        /// </summary>
        public WebhookProjectsV2ItemReorderedChanges()
        {
        }
    }
}