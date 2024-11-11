﻿//HintName: G.Models.AssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessage
    {
        /// <summary>
        /// The role of an individual message.<br/>
        /// - `user`:  Input provided by the user. Any instructions given here that conflict<br/>
        ///   with instructions given in the `system` prompt take precedence over the `system`<br/>
        ///   prompt instructions.<br/>
        /// - `assistant`:  Response generated by the model.<br/>
        /// - `system`:  Initial instructions provided to the system to provide general guidance<br/>
        ///   on the tone and voice of the generated message. An initial system message is<br/>
        ///   optional but recommended to provide guidance on the tone of the chat. For<br/>
        ///   example, "You are a helpful chatbot with a background in earth sciences and a<br/>
        ///   charming French accent."<br/>
        /// Default Value: assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.AssistantMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of an individual message.<br/>
        /// - `user`:  Input provided by the user. Any instructions given here that conflict<br/>
        ///   with instructions given in the `system` prompt take precedence over the `system`<br/>
        ///   prompt instructions.<br/>
        /// - `assistant`:  Response generated by the model.<br/>
        /// - `system`:  Initial instructions provided to the system to provide general guidance<br/>
        ///   on the tone and voice of the generated message. An initial system message is<br/>
        ///   optional but recommended to provide guidance on the tone of the chat. For<br/>
        ///   example, "You are a helpful chatbot with a background in earth sciences and a<br/>
        ///   charming French accent."<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="content"></param>
        /// <param name="toolCalls"></param>
        public AssistantMessage(
            global::G.AssistantMessageRole? role,
            string? content,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        public AssistantMessage()
        {
        }
    }
}