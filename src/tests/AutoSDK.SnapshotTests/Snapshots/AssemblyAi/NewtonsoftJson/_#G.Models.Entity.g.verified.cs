﻿//HintName: G.Models.Entity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A detected entity
    /// </summary>
    public sealed partial class Entity
    {
        /// <summary>
        /// The type of entity for the detected entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EntityType EntityType { get; set; } = default!;

        /// <summary>
        /// The text for the detected entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, at which the detected entity appears in the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The ending time, in milliseconds, for the detected entity in the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="entityType">
        /// The type of entity for the detected entity
        /// </param>
        /// <param name="text">
        /// The text for the detected entity
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, at which the detected entity appears in the audio file
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, for the detected entity in the audio file
        /// </param>
        public Entity(
            global::G.EntityType entityType,
            string text,
            int start,
            int end)
        {
            this.EntityType = entityType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        public Entity()
        {
        }
    }
}