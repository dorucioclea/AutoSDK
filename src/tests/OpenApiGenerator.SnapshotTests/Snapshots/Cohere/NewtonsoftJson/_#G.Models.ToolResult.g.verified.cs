﻿//HintName: G.Models.ToolResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResult
    {
        /// <summary>
        /// Contains the tool calls generated by the model. Use it to invoke your tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolCall Call { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolResultOutput> Outputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}