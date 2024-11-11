﻿//HintName: G.Models.ChatToolCallStartEventVariant2Delta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallStartEventVariant2Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call")]
        public global::G.ChatToolCallStartEventVariant2DeltaToolCall? ToolCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallStartEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="toolCall"></param>
        public ChatToolCallStartEventVariant2Delta(
            global::G.ChatToolCallStartEventVariant2DeltaToolCall? toolCall)
        {
            this.ToolCall = toolCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallStartEventVariant2Delta" /> class.
        /// </summary>
        public ChatToolCallStartEventVariant2Delta()
        {
        }
    }
}