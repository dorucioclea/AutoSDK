﻿//HintName: G.Models.WebhookDeploymentReviewApproved.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewApproved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookDeploymentReviewApprovedActionJsonConverter))]
        public global::G.WebhookDeploymentReviewApprovedAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approver")]
        public global::G.WebhooksApprover? Approver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::G.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::G.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationSimpleWebhooks Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryWebhooks Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::G.WebhooksReviewer>? Reviewers { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Since { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_job_run")]
        public global::G.WebhooksWorkflowJobRun? WorkflowJobRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_job_runs")]
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowJobRun>? WorkflowJobRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentReviewApprovedWorkflowRun? WorkflowRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApproved" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="approver"></param>
        /// <param name="comment"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="reviewers"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="since"></param>
        /// <param name="workflowJobRun"></param>
        /// <param name="workflowJobRuns"></param>
        /// <param name="workflowRun"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDeploymentReviewApproved(
            global::G.OrganizationSimpleWebhooks organization,
            global::G.RepositoryWebhooks repository,
            global::G.SimpleUser sender,
            string since,
            global::G.WebhookDeploymentReviewApprovedWorkflowRun? workflowRun,
            global::G.WebhookDeploymentReviewApprovedAction action,
            global::G.WebhooksApprover? approver,
            string? comment,
            global::G.EnterpriseWebhooks? enterprise,
            global::G.SimpleInstallation? installation,
            global::System.Collections.Generic.IList<global::G.WebhooksReviewer>? reviewers,
            global::G.WebhooksWorkflowJobRun? workflowJobRun,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowJobRun>? workflowJobRuns)
        {
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Since = since ?? throw new global::System.ArgumentNullException(nameof(since));
            this.WorkflowRun = workflowRun ?? throw new global::System.ArgumentNullException(nameof(workflowRun));
            this.Action = action;
            this.Approver = approver;
            this.Comment = comment;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Reviewers = reviewers;
            this.WorkflowJobRun = workflowJobRun;
            this.WorkflowJobRuns = workflowJobRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApproved" /> class.
        /// </summary>
        public WebhookDeploymentReviewApproved()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.WebhookDeploymentReviewApproved? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookDeploymentReviewApproved),
                jsonSerializerContext) as global::G.WebhookDeploymentReviewApproved;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookDeploymentReviewApproved? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookDeploymentReviewApproved>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewApproved?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookDeploymentReviewApproved),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookDeploymentReviewApproved;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewApproved?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookDeploymentReviewApproved?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}