﻿//HintName: G.Models.FineTuneChatCompletionRequestAssistantMessageVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneChatCompletionRequestAssistantMessageVariant1
    {
        /// <summary>
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageVariant1" /> class.
        /// </summary>
        /// <param name="weight">
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </param>
        public FineTuneChatCompletionRequestAssistantMessageVariant1(
            int? weight)
        {
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageVariant1" /> class.
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessageVariant1()
        {
        }
    }
}