﻿//HintName: G.Models.CreateImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.
        /// <br/>Example: A cute baby sea otter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for image generation.
        /// <br/>Default Value: dall-e-2
        /// <br/>Example: dall-e-3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public object? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.
        /// <br/>Default Value: standard
        /// <br/>Example: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; } = CreateImageRequestQuality.Standard;

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`.
        /// <br/>Default Value: url
        /// <br/>Example: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public string? ResponseFormat { get; set; } = CreateImageRequestResponseFormat.Url;

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.
        /// <br/>Default Value: 1024x1024
        /// <br/>Example: 1024x1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; } = CreateImageRequestSize._1024x1024;

        /// <summary>
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.
        /// <br/>Default Value: vivid
        /// <br/>Example: vivid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; } = CreateImageRequestStyle.Vivid;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// <br/>Example: user-1234
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}