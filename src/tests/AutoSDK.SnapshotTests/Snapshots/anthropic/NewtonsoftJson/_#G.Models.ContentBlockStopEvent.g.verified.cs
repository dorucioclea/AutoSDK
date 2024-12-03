﻿//HintName: G.Models.ContentBlockStopEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A stop event in a streaming content block.
    /// </summary>
    public sealed partial class ContentBlockStopEvent
    {
        /// <summary>
        /// The index of the content block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content block.
        /// </param>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        public ContentBlockStopEvent(
            int index,
            global::G.MessageStreamEventType type)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        public ContentBlockStopEvent()
        {
        }
    }
}