﻿//HintName: G.Models.ImageEmbeddingInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class ImageEmbeddingInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// List of images to embed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ApiSchemasEmbeddingImageDoc, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingImageDoc>> Input { get; set; } = default!;

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_type")]
        public global::G.AnyOf<global::G.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.ImageEmbeddingInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </param>
        /// <param name="input">
        /// List of images to embed
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="normalized">
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </param>
        public ImageEmbeddingInput(
            string model,
            global::G.AnyOf<global::G.ApiSchemasEmbeddingImageDoc, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingImageDoc>> input,
            global::G.AnyOf<global::G.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.ImageEmbeddingInputEmbeddingTypeItem>>? embeddingType,
            bool? normalized)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingInput" /> class.
        /// </summary>
        public ImageEmbeddingInput()
        {
        }
    }
}