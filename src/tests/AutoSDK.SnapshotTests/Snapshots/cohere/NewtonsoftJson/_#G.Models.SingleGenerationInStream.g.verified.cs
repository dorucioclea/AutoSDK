﻿//HintName: G.Models.SingleGenerationInStream.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleGenerationInStream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Full text of the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationInStream" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text">
        /// Full text of the generation.
        /// </param>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </param>
        /// <param name="finishReason"></param>
        public SingleGenerationInStream(
            string id,
            string text,
            global::G.FinishReason finishReason,
            int? index)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FinishReason = finishReason;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationInStream" /> class.
        /// </summary>
        public SingleGenerationInStream()
        {
        }
    }
}