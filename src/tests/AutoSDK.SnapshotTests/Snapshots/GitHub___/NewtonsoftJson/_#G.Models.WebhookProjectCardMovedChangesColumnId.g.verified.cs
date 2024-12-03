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
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public int From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChangesColumnId" /> class.
        /// </summary>
        /// <param name="from"></param>
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