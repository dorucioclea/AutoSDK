﻿//HintName: G.Models.PipelineGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IOVariable> InputVariables { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IOVariable> OutputVariables { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accelerators")]
        public global::System.Collections.Generic.IList<global::G.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// A lean representation of a cluster when returned from an API call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cluster")]
        public global::G.PipelineClusterGetLean? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scaling_config")]
        public string? ScalingConfig { get; set; }

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_state_info")]
        public global::G.PipelineContainerState? FailedStateInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineGet" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="extras"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="accelerators"></param>
        /// <param name="cluster">
        /// A lean representation of a cluster when returned from an API call
        /// </param>
        /// <param name="scalingConfig"></param>
        /// <param name="failedStateInfo">
        /// Base model for schemas.
        /// </param>
        public PipelineGet(
            string name,
            string image,
            global::System.Collections.Generic.IList<global::G.IOVariable> inputVariables,
            global::System.Collections.Generic.IList<global::G.IOVariable> outputVariables,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? extras,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators,
            global::G.PipelineClusterGetLean? cluster,
            string? scalingConfig,
            global::G.PipelineContainerState? failedStateInfo)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Extras = extras;
            this.Accelerators = accelerators;
            this.Cluster = cluster;
            this.ScalingConfig = scalingConfig;
            this.FailedStateInfo = failedStateInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineGet" /> class.
        /// </summary>
        public PipelineGet()
        {
        }
    }
}