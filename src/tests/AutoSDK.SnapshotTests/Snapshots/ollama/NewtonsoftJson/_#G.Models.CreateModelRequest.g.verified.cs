﻿//HintName: G.Models.CreateModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create model request object.
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: mario
        /// </summary>
        /// <example>mario</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The contents of the Modelfile.<br/>
        /// Example: FROM llama3\nSYSTEM You are mario from Super Mario Bros.
        /// </summary>
        /// <example>FROM llama3\nSYSTEM You are mario from Super Mario Bros.</example>
        [global::Newtonsoft.Json.JsonProperty("modelfile", Required = global::Newtonsoft.Json.Required.Always)]
        public string Modelfile { get; set; } = default!;

        /// <summary>
        /// Path to the Modelfile (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The quantization level of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantize")]
        public string? Quantize { get; set; }

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: mario
        /// </param>
        /// <param name="modelfile">
        /// The contents of the Modelfile.<br/>
        /// Example: FROM llama3\nSYSTEM You are mario from Super Mario Bros.
        /// </param>
        /// <param name="path">
        /// Path to the Modelfile (optional)
        /// </param>
        /// <param name="quantize">
        /// The quantization level of the model.
        /// </param>
        /// <param name="stream">
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.<br/>
        /// Default Value: true
        /// </param>
        public CreateModelRequest(
            string model,
            string modelfile,
            string? path,
            string? quantize,
            bool? stream)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Modelfile = modelfile ?? throw new global::System.ArgumentNullException(nameof(modelfile));
            this.Path = path;
            this.Quantize = quantize;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }
    }
}