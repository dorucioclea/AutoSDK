﻿//HintName: G.Models.EvaluatorStructuredOutput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Evaluator structured output schema.
    /// </summary>
    public sealed partial class EvaluatorStructuredOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hub_ref")]
        public global::G.AnyOf<string, object>? HubRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>, object>? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format")]
        public global::G.AnyOf<string, object>? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public global::G.AnyOf<object, object>? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variable_mapping")]
        public global::G.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, object>? VariableMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}