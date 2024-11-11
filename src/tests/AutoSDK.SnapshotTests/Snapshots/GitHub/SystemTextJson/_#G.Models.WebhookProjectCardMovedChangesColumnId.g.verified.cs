﻿//HintName: G.Models.WebhookProjectCardMovedChangesColumnId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardMovedChangesColumnId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChangesColumnId" /> class.
        /// </summary>
        /// <param name="from"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookProjectCardMovedChangesColumnId(
            int from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChangesColumnId" /> class.
        /// </summary>
        public WebhookProjectCardMovedChangesColumnId()
        {
        }
    }
}