﻿//HintName: G.Models.CreateImageVariationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageVariationRequest
    {
        /// <summary>
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Image { get; set; } = default!;

        /// <summary>
        /// The model to use for image generation. Only `dall-e-2` is supported at this time.
        /// <br/>Default Value: dall-e-2
        /// <br/>Example: dall-e-2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public object? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`.
        /// <br/>Default Value: url
        /// <br/>Example: url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public CreateImageVariationRequestResponseFormat? ResponseFormat { get; set; } = CreateImageVariationRequestResponseFormat.Url;

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.
        /// <br/>Default Value: 1024x1024
        /// <br/>Example: 1024x1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public CreateImageVariationRequestSize? Size { get; set; } = CreateImageVariationRequestSize._1024x1024;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// <br/>Example: user-1234
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}