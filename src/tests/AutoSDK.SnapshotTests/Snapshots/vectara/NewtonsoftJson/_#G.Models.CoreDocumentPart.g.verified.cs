﻿//HintName: G.Models.CoreDocumentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A part of a document. This section gets converted into an embedding and directly maps to a search result. Usually a sentence.
    /// </summary>
    public sealed partial class CoreDocumentPart
    {
        /// <summary>
        /// The text of the document part.<br/>
        /// Example: I'm a nice document part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The metadata for a document part. Attributes matching corpus document part filter attributes are used as document part filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.CoreDocumentPartMetadata? Metadata { get; set; }

        /// <summary>
        /// The context text for the document part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::G.CustomDimensions? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}