﻿//HintName: G.Models.WorkflowUsageBillableMACOS.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillableMACOS
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_ms")]
        public int? TotalMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableMACOS" /> class.
        /// </summary>
        /// <param name="totalMs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WorkflowUsageBillableMACOS(
            int? totalMs)
        {
            this.TotalMs = totalMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillableMACOS" /> class.
        /// </summary>
        public WorkflowUsageBillableMACOS()
        {
        }
    }
}