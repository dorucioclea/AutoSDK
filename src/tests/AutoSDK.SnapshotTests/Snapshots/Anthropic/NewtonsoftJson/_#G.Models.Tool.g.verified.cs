﻿//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool the model may use.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The name of the tool. Must match the regex `^[a-zA-Z0-9_-]{1,64}$`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that<br/>
        /// the model has about what the tool is and how to use it, the better it will<br/>
        /// perform. You can use natural language descriptions to reinforce important<br/>
        /// aspects of the tool input JSON schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model<br/>
        /// will produce.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object InputSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}