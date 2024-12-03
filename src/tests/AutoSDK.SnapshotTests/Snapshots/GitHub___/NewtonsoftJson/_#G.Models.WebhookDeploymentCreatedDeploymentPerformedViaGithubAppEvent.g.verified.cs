﻿//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_protection_rule")]
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_run")]
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_suite")]
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning_alert")]
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_comment")]
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_reference")]
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment")]
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_review")]
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_status")]
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deploy_key")]
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion")]
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_comment")]
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fork")]
        Fork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gollum")]
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issues")]
        Issues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_comment")]
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="label")]
        Label,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="membership")]
        Membership,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="milestone")]
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_block")]
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_build")]
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_card")]
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_column")]
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review")]
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_comment")]
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registry_package")]
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="release")]
        Release,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository")]
        Repository,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_dispatch")]
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert")]
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="star")]
        Star,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team_add")]
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watch")]
        Watch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_dispatch")]
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_run")]
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_job")]
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_thread")]
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue_entry")]
        MergeQueueEntry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert_location")]
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_group")]
        MergeGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Create => "create",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Delete => "delete",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork => "fork",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues => "issues",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label => "label",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member => "member",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership => "membership",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization => "organization",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project => "project",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public => "public",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push => "push",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release => "release",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository => "repository",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star => "star",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status => "status",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team => "team",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch => "watch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob => "workflow_job",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry => "merge_queue_entry",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup => "merge_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Create,
                "delete" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Label,
                "member" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Member,
                "membership" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Project,
                "project_card" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Release,
                "repository" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Star,
                "status" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Status,
                "team" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Team,
                "team_add" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowRun,
                "workflow_job" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.WorkflowJob,
                "pull_request_review_thread" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.PullRequestReviewThread,
                "merge_queue_entry" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeQueueEntry,
                "secret_scanning_alert_location" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.SecretScanningAlertLocation,
                "merge_group" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent.MergeGroup,
                _ => null,
            };
        }
    }
}