﻿//HintName: G.Models.Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information of a job execution in a workflow run
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// The id of the job.<br/>
        /// Example: 21
        /// </summary>
        /// <example>21</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The id of the associated workflow run.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5</example>
        [global::Newtonsoft.Json.JsonProperty("run_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunUrl { get; set; } = default!;

        /// <summary>
        /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        /// <example>MDg6Q2hlY2tSdW40</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit that is being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/jobs/21
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/jobs/21</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        /// <example>https://github.com/github/hello-world/runs/4</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobStatus Status { get; set; } = default!;

        /// <summary>
        /// The outcome of the job.<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// The time that the job created, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the job started, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The time that the job finished, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CompletedAt { get; set; } = default!;

        /// <summary>
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </summary>
        /// <example>test-coverage</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Steps in this job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public global::System.Collections.Generic.IList<global::G.JobStep>? Steps { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/check-runs/4</example>
        [global::Newtonsoft.Json.JsonProperty("check_run_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckRunUrl { get; set; } = default!;

        /// <summary>
        /// Labels for the workflow job. Specified by the "runs_on" attribute in the action's workflow file.<br/>
        /// Example: [self-hosted, foo, bar]
        /// </summary>
        /// <example>[self-hosted, foo, bar]</example>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("runner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RunnerId { get; set; } = default!;

        /// <summary>
        /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner
        /// </summary>
        /// <example>my runner</example>
        [global::Newtonsoft.Json.JsonProperty("runner_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RunnerName { get; set; } = default!;

        /// <summary>
        /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RunnerGroupId { get; set; } = default!;

        /// <summary>
        /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner group
        /// </summary>
        /// <example>my runner group</example>
        [global::Newtonsoft.Json.JsonProperty("runner_group_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RunnerGroupName { get; set; } = default!;

        /// <summary>
        /// The name of the workflow.<br/>
        /// Example: Build
        /// </summary>
        /// <example>Build</example>
        [global::Newtonsoft.Json.JsonProperty("workflow_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WorkflowName { get; set; } = default!;

        /// <summary>
        /// The name of the current branch.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::Newtonsoft.Json.JsonProperty("head_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HeadBranch { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the job.<br/>
        /// Example: 21
        /// </param>
        /// <param name="runId">
        /// The id of the associated workflow run.<br/>
        /// Example: 5
        /// </param>
        /// <param name="runUrl">
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </param>
        /// <param name="runAttempt">
        /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6Q2hlY2tSdW40
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit that is being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/actions/jobs/21
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/runs/4
        /// </param>
        /// <param name="status">
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </param>
        /// <param name="conclusion">
        /// The outcome of the job.<br/>
        /// Example: success
        /// </param>
        /// <param name="createdAt">
        /// The time that the job created, in ISO 8601 format.
        /// </param>
        /// <param name="startedAt">
        /// The time that the job started, in ISO 8601 format.
        /// </param>
        /// <param name="completedAt">
        /// The time that the job finished, in ISO 8601 format.
        /// </param>
        /// <param name="name">
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </param>
        /// <param name="steps">
        /// Steps in this job.
        /// </param>
        /// <param name="checkRunUrl">
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </param>
        /// <param name="labels">
        /// Labels for the workflow job. Specified by the "runs_on" attribute in the action's workflow file.<br/>
        /// Example: [self-hosted, foo, bar]
        /// </param>
        /// <param name="runnerId">
        /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 1
        /// </param>
        /// <param name="runnerName">
        /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 2
        /// </param>
        /// <param name="runnerGroupName">
        /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner group
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.<br/>
        /// Example: Build
        /// </param>
        /// <param name="headBranch">
        /// The name of the current branch.<br/>
        /// Example: main
        /// </param>
        public Job(
            int id,
            int runId,
            string runUrl,
            string nodeId,
            string headSha,
            string url,
            string? htmlUrl,
            global::G.JobStatus status,
            global::G.JobConclusion? conclusion,
            global::System.DateTime createdAt,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt,
            string name,
            string checkRunUrl,
            global::System.Collections.Generic.IList<string> labels,
            int? runnerId,
            string? runnerName,
            int? runnerGroupId,
            string? runnerGroupName,
            string? workflowName,
            string? headBranch,
            int? runAttempt,
            global::System.Collections.Generic.IList<global::G.JobStep>? steps)
        {
            this.Id = id;
            this.RunId = runId;
            this.RunUrl = runUrl ?? throw new global::System.ArgumentNullException(nameof(runUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Status = status;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CheckRunUrl = checkRunUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunUrl));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.RunnerId = runnerId;
            this.RunnerName = runnerName ?? throw new global::System.ArgumentNullException(nameof(runnerName));
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName ?? throw new global::System.ArgumentNullException(nameof(runnerGroupName));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.RunAttempt = runAttempt;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}