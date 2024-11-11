﻿//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewApprovedWorkflowRunPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequestBase Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequestHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApprovedWorkflowRunPullRequest" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="head"></param>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="url"></param>
        public WebhookDeploymentReviewApprovedWorkflowRunPullRequest(
            global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequestBase @base,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequestHead head,
            int id,
            int number,
            string url)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Id = id;
            this.Number = number;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApprovedWorkflowRunPullRequest" /> class.
        /// </summary>
        public WebhookDeploymentReviewApprovedWorkflowRunPullRequest()
        {
        }
    }
}