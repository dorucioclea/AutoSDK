﻿//HintName: G.Models.WorkflowRunUsageBillableWINDOWS.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUsageBillableWINDOWS
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_runs")]
        public global::System.Collections.Generic.IList<global::G.WorkflowRunUsageBillableWINDOWSJobRun>? JobRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableWINDOWS" /> class.
        /// </summary>
        /// <param name="totalMs"></param>
        /// <param name="jobs"></param>
        /// <param name="jobRuns"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WorkflowRunUsageBillableWINDOWS(
            int totalMs,
            int jobs,
            global::System.Collections.Generic.IList<global::G.WorkflowRunUsageBillableWINDOWSJobRun>? jobRuns)
        {
            this.TotalMs = totalMs;
            this.Jobs = jobs;
            this.JobRuns = jobRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillableWINDOWS" /> class.
        /// </summary>
        public WorkflowRunUsageBillableWINDOWS()
        {
        }
    }
}