﻿//HintName: G.Models.ClonePipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ClonePipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cluster", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelineClusterConfig Cluster { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accelerators")]
        public global::System.Collections.Generic.IList<global::G.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipeline" /> class.
        /// </summary>
        /// <param name="cluster"></param>
        /// <param name="accelerators"></param>
        public ClonePipeline(
            global::G.PipelineClusterConfig cluster,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators)
        {
            this.Cluster = cluster ?? throw new global::System.ArgumentNullException(nameof(cluster));
            this.Accelerators = accelerators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePipeline" /> class.
        /// </summary>
        public ClonePipeline()
        {
        }
    }
}