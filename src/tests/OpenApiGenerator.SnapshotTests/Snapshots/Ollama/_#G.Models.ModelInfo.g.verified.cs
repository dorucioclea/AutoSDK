﻿//HintName: G.Models.ModelInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a model including modelfile, template, parameters, license, and system prompt.
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// The model's license.
        /// <br/>Example: <contents of license block>
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// The modelfile associated with the model.
        /// <br/>Example: Modelfile generated by \"ollama show\"\n# To build a new Modelfile based on this one, replace the FROM line with:\n# FROM llama2:latest\n\nFROM /Users/username/.ollama/models/blobs/sha256:8daa9615cce30c259a9555b1cc250d461d1bc69980a274b44d7eda0be78076d8\nTEMPLATE \"\"\"[INST] {{ if and .First .System }}<<SYS>>{{ .System }}<</SYS>>\n\n{{ end }}{{ .Prompt }} [/INST] \"\"\"\nSYSTEM \"\"\"\"\"\"\nPARAMETER stop [INST]\nPARAMETER stop [/INST]\nPARAMETER stop <<SYS>>\nPARAMETER stop <</SYS>>\n"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelfile")]
        public string? Modelfile { get; set; }

        /// <summary>
        /// The model parameters.
        /// <br/>Example: stop [INST]\nstop [/INST]\nstop <<SYS>>\nstop <</SYS>>
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public string? Parameters { get; set; }

        /// <summary>
        /// The prompt template for the model.
        /// <br/>Example: [INST] {{ if and .First .System }}<<SYS>>{{ .System }}<</SYS>>\n\n{{ end }}{{ .Prompt }} [/INST]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}