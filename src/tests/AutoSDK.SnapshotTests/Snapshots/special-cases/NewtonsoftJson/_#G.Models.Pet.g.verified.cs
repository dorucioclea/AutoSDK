﻿//HintName: G.Models.Pet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pet
    {
        /// <summary>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::Newtonsoft.Json.JsonProperty("4")]
        public string? x4 { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("1.5")]
        public bool? x15 { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("16:9")]
        public bool? x16_9 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        /// <param name="x4">
        /// Example: 1234
        /// </param>
        /// <param name="x15">
        /// Example: true
        /// </param>
        /// <param name="x16_9">
        /// Example: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        public Pet(
            long id,
            string name,
            string? x4,
            bool? x15,
            bool? x16_9,
            string? tag)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.x4 = x4;
            this.x15 = x15;
            this.x16_9 = x16_9;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        public Pet()
        {
        }
    }
}