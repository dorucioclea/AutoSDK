﻿//HintName: G.Models.CreateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a chat completion response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateChatCompletionResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A list of chat completion choices. Can be more than one if `n` is greater than 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<CreateChatCompletionResponseChoices> Choices { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateChatCompletionResponseObject Object { get; set; } = default!;

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}