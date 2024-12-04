﻿//HintName: G.Models.RealtimeConversationItemContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemContentItem
    {
        /// <summary>
        /// The content type (`input_text`, `input_audio`, `text`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeConversationItemContentItemType? Type { get; set; }

        /// <summary>
        /// The text content, used for `input_text` and `text` content types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio, used for `input_audio` content type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type (`input_text`, `input_audio`, `text`).
        /// </param>
        /// <param name="text">
        /// The text content, used for `input_text` and `text` content types.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio, used for `input_audio` content type.
        /// </param>
        public RealtimeConversationItemContentItem(
            global::G.RealtimeConversationItemContentItemType? type,
            string? text,
            string? audio,
            string? transcript)
        {
            this.Type = type;
            this.Text = text;
            this.Audio = audio;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemContentItem()
        {
        }
    }
}