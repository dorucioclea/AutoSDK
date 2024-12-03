﻿//HintName: G.Models.SentencesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptSentence> Sentences { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="sentences"></param>
        public SentencesResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptSentence> sentences)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        public SentencesResponse()
        {
        }
    }
}