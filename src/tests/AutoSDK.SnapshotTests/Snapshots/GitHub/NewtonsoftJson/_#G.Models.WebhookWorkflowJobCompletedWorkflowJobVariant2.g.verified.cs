﻿//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobCompletedWorkflowJobVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_run_url")]
        public string? CheckRunUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion Conclusion { get; set; } = default!;

        /// <summary>
        /// The time that the job created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public int? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_url")]
        public string? RunUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id")]
        public double? RunnerGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_name")]
        public string? RunnerGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id")]
        public double? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_name")]
        public string? RunnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The name of the current branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public global::System.Collections.Generic.IList<object>? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobCompletedWorkflowJobVariant2" /> class.
        /// </summary>
        /// <param name="checkRunUrl"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="createdAt">
        /// The time that the job created.
        /// </param>
        /// <param name="headSha"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="runId"></param>
        /// <param name="runUrl"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runnerGroupName"></param>
        /// <param name="runnerId"></param>
        /// <param name="runnerName"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="headBranch">
        /// The name of the current branch.
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.
        /// </param>
        /// <param name="steps"></param>
        /// <param name="url"></param>
        public WebhookWorkflowJobCompletedWorkflowJobVariant2(
            global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion conclusion,
            string? checkRunUrl,
            string? completedAt,
            string? createdAt,
            string? headSha,
            string? htmlUrl,
            int? id,
            global::System.Collections.Generic.IList<string>? labels,
            string? name,
            string? nodeId,
            int? runAttempt,
            int? runId,
            string? runUrl,
            double? runnerGroupId,
            string? runnerGroupName,
            double? runnerId,
            string? runnerName,
            string? startedAt,
            string? status,
            string? headBranch,
            string? workflowName,
            global::System.Collections.Generic.IList<object>? steps,
            string? url)
        {
            this.Conclusion = conclusion;
            this.CheckRunUrl = checkRunUrl;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.HeadSha = headSha;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.Labels = labels;
            this.Name = name;
            this.NodeId = nodeId;
            this.RunAttempt = runAttempt;
            this.RunId = runId;
            this.RunUrl = runUrl;
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName;
            this.RunnerId = runnerId;
            this.RunnerName = runnerName;
            this.StartedAt = startedAt;
            this.Status = status;
            this.HeadBranch = headBranch;
            this.WorkflowName = workflowName;
            this.Steps = steps;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobCompletedWorkflowJobVariant2" /> class.
        /// </summary>
        public WebhookWorkflowJobCompletedWorkflowJobVariant2()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2?>(serializer.Deserialize<global::G.WebhookWorkflowJobCompletedWorkflowJobVariant2>(jsonReader));
        }

    }
}