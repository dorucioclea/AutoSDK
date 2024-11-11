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
        /// The model's license.<br/>
        /// Example: &lt;contents of license block&gt;
        /// </summary>
        /// <example>&lt;contents of license block&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// The modelfile associated with the model.<br/>
        /// Example: Modelfile generated by \"ollama show\"\n# To build a new Modelfile based on this one, replace the FROM line with:\n# FROM llama3:latest\n\nFROM /Users/username/.ollama/models/blobs/sha256:8daa9615cce30c259a9555b1cc250d461d1bc69980a274b44d7eda0be78076d8\nTEMPLATE \"\"\"[INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST] \"\"\"\nSYSTEM \"\"\"\"\"\"\nPARAMETER stop [INST]\nPARAMETER stop [/INST]\nPARAMETER stop &lt;&lt;SYS&gt;&gt;\nPARAMETER stop &lt;&lt;/SYS&gt;&gt;\n"
        /// </summary>
        /// <example>Modelfile generated by \"ollama show\"\n# To build a new Modelfile based on this one, replace the FROM line with:\n# FROM llama3:latest\n\nFROM /Users/username/.ollama/models/blobs/sha256:8daa9615cce30c259a9555b1cc250d461d1bc69980a274b44d7eda0be78076d8\nTEMPLATE \"\"\"[INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST] \"\"\"\nSYSTEM \"\"\"\"\"\"\nPARAMETER stop [INST]\nPARAMETER stop [/INST]\nPARAMETER stop &lt;&lt;SYS&gt;&gt;\nPARAMETER stop &lt;&lt;/SYS&gt;&gt;\n"</example>
        [global::Newtonsoft.Json.JsonProperty("modelfile")]
        public string? Modelfile { get; set; }

        /// <summary>
        /// The model parameters.<br/>
        /// Example: stop [INST]\nstop [/INST]\nstop &lt;&lt;SYS&gt;&gt;\nstop &lt;&lt;/SYS&gt;&gt;
        /// </summary>
        /// <example>stop [INST]\nstop [/INST]\nstop &lt;&lt;SYS&gt;&gt;\nstop &lt;&lt;/SYS&gt;&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public string? Parameters { get; set; }

        /// <summary>
        /// The prompt template for the model.<br/>
        /// Example: [INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST]
        /// </summary>
        /// <example>[INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST]</example>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public string? Template { get; set; }

        /// <summary>
        /// The system prompt for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system")]
        public string? System { get; set; }

        /// <summary>
        /// Details about a model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.ModelDetails? Details { get; set; }

        /// <summary>
        /// Details about a model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_info")]
        public global::G.ModelInformation? ModelInfo1 { get; set; }

        /// <summary>
        /// The default messages for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.Message>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="license">
        /// The model's license.<br/>
        /// Example: &lt;contents of license block&gt;
        /// </param>
        /// <param name="modelfile">
        /// The modelfile associated with the model.<br/>
        /// Example: Modelfile generated by \"ollama show\"\n# To build a new Modelfile based on this one, replace the FROM line with:\n# FROM llama3:latest\n\nFROM /Users/username/.ollama/models/blobs/sha256:8daa9615cce30c259a9555b1cc250d461d1bc69980a274b44d7eda0be78076d8\nTEMPLATE \"\"\"[INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST] \"\"\"\nSYSTEM \"\"\"\"\"\"\nPARAMETER stop [INST]\nPARAMETER stop [/INST]\nPARAMETER stop &lt;&lt;SYS&gt;&gt;\nPARAMETER stop &lt;&lt;/SYS&gt;&gt;\n"
        /// </param>
        /// <param name="parameters">
        /// The model parameters.<br/>
        /// Example: stop [INST]\nstop [/INST]\nstop &lt;&lt;SYS&gt;&gt;\nstop &lt;&lt;/SYS&gt;&gt;
        /// </param>
        /// <param name="template">
        /// The prompt template for the model.<br/>
        /// Example: [INST] {{ if and .First .System }}&lt;&lt;SYS&gt;&gt;{{ .System }}&lt;&lt;/SYS&gt;&gt;\n\n{{ end }}{{ .Prompt }} [/INST]
        /// </param>
        /// <param name="system">
        /// The system prompt for the model.
        /// </param>
        /// <param name="details">
        /// Details about a model.
        /// </param>
        /// <param name="modelInfo1">
        /// Details about a model.
        /// </param>
        /// <param name="messages">
        /// The default messages for the model.
        /// </param>
        public ModelInfo(
            string? license,
            string? modelfile,
            string? parameters,
            string? template,
            string? system,
            global::G.ModelDetails? details,
            global::G.ModelInformation? modelInfo1,
            global::System.Collections.Generic.IList<global::G.Message>? messages)
        {
            this.License = license;
            this.Modelfile = modelfile;
            this.Parameters = parameters;
            this.Template = template;
            this.System = system;
            this.Details = details;
            this.ModelInfo1 = modelInfo1;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}