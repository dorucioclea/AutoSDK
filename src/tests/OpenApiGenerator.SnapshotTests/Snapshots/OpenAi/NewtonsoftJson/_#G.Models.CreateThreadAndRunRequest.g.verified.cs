﻿//HintName: G.Models.CreateThreadAndRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadAndRunRequest
    {
        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread")]
        public CreateThreadRequest? Thread { get; set; }

        /// <summary>
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<object?>? Tools { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public CreateThreadAndRunRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}