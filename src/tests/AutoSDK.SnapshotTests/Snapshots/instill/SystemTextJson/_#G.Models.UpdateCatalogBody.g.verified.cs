﻿//HintName: G.Models.UpdateCatalogBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateCatalogRequest represents a request to update a catalog.
    /// </summary>
    public sealed partial class UpdateCatalogBody
    {
        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}