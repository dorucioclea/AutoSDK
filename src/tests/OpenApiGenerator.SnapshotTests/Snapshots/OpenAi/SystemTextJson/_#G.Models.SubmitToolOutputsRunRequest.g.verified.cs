﻿//HintName: G.Models.SubmitToolOutputsRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRunRequest
    {
        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<SubmitToolOutputsRunRequestToolOutputs> ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}