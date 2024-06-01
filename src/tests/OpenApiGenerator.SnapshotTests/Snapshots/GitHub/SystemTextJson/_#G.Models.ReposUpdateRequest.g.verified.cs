﻿//HintName: G.Models.ReposUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateRequest
    {
        /// <summary>
        /// The name of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A short description of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL with more information about the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// Either `true` to make the repository private or `false` to make it public. Default: `false`.  
        /// **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool Private { get; set; } = false;

        /// <summary>
        /// The visibility of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateRequestVisibilityJsonConverter))]
        public ReposUpdateRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Specify which security and analysis features to enable or disable for the repository.
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."
        /// For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:
        /// `{ "security_and_analysis": {"advanced_security": { "status": "enabled" } } }`.
        /// You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_and_analysis")]
        public ReposUpdateRequestSecurityAndAnalysis? SecurityAndAnalysis { get; set; }

        /// <summary>
        /// Either `true` to enable issues for this repository or `false` to disable them.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        public bool HasIssues { get; set; } = true;

        /// <summary>
        /// Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you're creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        public bool HasProjects { get; set; } = true;

        /// <summary>
        /// Either `true` to enable the wiki for this repository or `false` to disable it.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        public bool HasWiki { get; set; } = true;

        /// <summary>
        /// Either `true` to make this repo available as a template repository or `false` to prevent it.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool IsTemplate { get; set; } = false;

        /// <summary>
        /// Updates the default branch for this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        public string? DefaultBranch { get; set; }

        /// <summary>
        /// Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_squash_merge")]
        public bool AllowSquashMerge { get; set; } = true;

        /// <summary>
        /// Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_merge_commit")]
        public bool AllowMergeCommit { get; set; } = true;

        /// <summary>
        /// Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.
        /// <br/>Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_rebase_merge")]
        public bool AllowRebaseMerge { get; set; } = true;

        /// <summary>
        /// Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_merge")]
        public bool AllowAutoMerge { get; set; } = false;

        /// <summary>
        /// Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; } = false;

        /// <summary>
        /// Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_update_branch")]
        public bool AllowUpdateBranch { get; set; } = false;

        /// <summary>
        /// Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message. **This property has been deprecated. Please use `squash_merge_commit_title` instead.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_squash_pr_title_as_default")]
        public bool UseSquashPrTitleAsDefault { get; set; } = false;

        /// <summary>
        /// The default value for a squash merge commit title:
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateRequestSquashMergeCommitTitleJsonConverter))]
        public ReposUpdateRequestSquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:
        /// - `PR_BODY` - default to the pull request's body.
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squash_merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateRequestSquashMergeCommitMessageJsonConverter))]
        public ReposUpdateRequestSquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateRequestMergeCommitTitleJsonConverter))]
        public ReposUpdateRequestMergeCommitTitle? MergeCommitTitle { get; set; }

        /// <summary>
        /// The default value for a merge commit message.
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `PR_BODY` - default to the pull request's body.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_commit_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateRequestMergeCommitMessageJsonConverter))]
        public ReposUpdateRequestMergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// Whether to archive this repository. `false` will unarchive a previously archived repository.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool Archived { get; set; } = false;

        /// <summary>
        /// Either `true` to allow private forks, or `false` to prevent private forks.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool AllowForking { get; set; } = false;

        /// <summary>
        /// Either `true` to require contributors to sign off on web-based commits, or `false` to not require contributors to sign off on web-based commits.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}