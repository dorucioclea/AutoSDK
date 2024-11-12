﻿//HintName: G.Models.VectorStoreExpirationAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expiration policy for a vector store.
    /// </summary>
    public sealed partial class VectorStoreExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anchor")]
        public global::G.VectorStoreExpirationAfterAnchor Anchor { get; set; }

        /// <summary>
        /// The number of days after the anchor time that the vector store will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days", Required = global::Newtonsoft.Json.Required.Always)]
        public int Days { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </param>
        /// <param name="days">
        /// The number of days after the anchor time that the vector store will expire.
        /// </param>
        public VectorStoreExpirationAfter(
            int days,
            global::G.VectorStoreExpirationAfterAnchor anchor)
        {
            this.Days = days;
            this.Anchor = anchor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        public VectorStoreExpirationAfter()
        {
        }
    }
}