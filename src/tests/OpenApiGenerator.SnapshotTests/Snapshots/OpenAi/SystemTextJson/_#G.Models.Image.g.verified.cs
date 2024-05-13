﻿//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents the url or the content of an image generated by the OpenAI API.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// The base64-encoded JSON of the generated image, if `response_format` is `b64_json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        public string? B64Json { get; set; }

        /// <summary>
        /// The URL of the generated image, if `response_format` is `url` (default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt that was used to generate the image, if there was any revision to the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}