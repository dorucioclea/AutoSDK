﻿//HintName: G.Models.RunStepDetailsToolCallsCodeObjectCodeInterpreter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Code Interpreter tool call definition.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeObjectCodeInterpreter
    {
        /// <summary>
        /// The input to the Code Interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (`logs`) or images (`image`). Each of these are represented by a different object type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput> Outputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreter" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the Code Interpreter tool call.
        /// </param>
        /// <param name="outputs">
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (`logs`) or images (`image`). Each of these are represented by a different object type.
        /// </param>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreter(
            string input,
            global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput> outputs)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreter" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreter()
        {
        }
    }
}