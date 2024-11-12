﻿//HintName: G.Models.NodePoolCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class NodePoolCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accelerators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Accelerator> Accelerators { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spot")]
        public bool? Spot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolCreate" /> class.
        /// </summary>
        /// <param name="accelerators"></param>
        /// <param name="spot">
        /// Default Value: true
        /// </param>
        public NodePoolCreate(
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool? spot)
        {
            this.Accelerators = accelerators ?? throw new global::System.ArgumentNullException(nameof(accelerators));
            this.Spot = spot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolCreate" /> class.
        /// </summary>
        public NodePoolCreate()
        {
        }
    }
}