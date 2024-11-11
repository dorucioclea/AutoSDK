﻿//HintName: G.Models.PagesDeploymentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesDeploymentStatus
    {
        /// <summary>
        /// The current status of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PagesDeploymentStatusStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of the deployment.
        /// </param>
        public PagesDeploymentStatus(
            global::G.PagesDeploymentStatusStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        public PagesDeploymentStatus()
        {
        }
    }
}