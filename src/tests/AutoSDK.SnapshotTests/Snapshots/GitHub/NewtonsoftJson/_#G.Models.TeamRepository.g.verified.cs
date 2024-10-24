﻿//HintName: G.Models.TeamRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A team's access to a repository.
    /// </summary>
    public sealed partial class TeamRepository
    {
        /// <summary>
        /// Unique identifier of the repository<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Team Environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// License Simple
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableLicenseSimple? License { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks", Required = global::Newtonsoft.Json.Required.Always)]
        public int Forks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.TeamRepositoryPermissions? Permissions { get; set; }

        /// <summary>
        /// Example: admin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Owner { get; set; } = default!;

        /// <summary>
        /// Whether the repository is private or public.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: This your first repo!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fork", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Fork { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArchiveUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/assignees{/user}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssigneesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blobs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/branches{/branch}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branches_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollaboratorsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/comments{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/commits{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compare_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompareUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/contents/{+path}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/contributors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributors_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContributorsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/deployments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/downloads
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downloads_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/forks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ForksUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_commits_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitCommitsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_refs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitRefsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitTagsUrl { get; set; } = default!;

        /// <summary>
        /// Example: git:github.com/octocat/Hello-World.git
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string GitUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueCommentUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues/events{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueEventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/issues{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/keys{/key_id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeysUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/labels{/name}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/languages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguagesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/merges
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merges_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MergesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/milestones{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestones_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MilestonesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/notifications{?since,all,participating}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notifications_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NotificationsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/pulls{/number}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pulls_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/releases{/id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("releases_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleasesUrl { get; set; } = default!;

        /// <summary>
        /// Example: git@github.com:octocat/Hello-World.git
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssh_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SshUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/stargazers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StargazersUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/statuses/{sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusesUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscribers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribers_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscribersUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/subscription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/teams
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamsUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trees_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World.git
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clone_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CloneUrl { get; set; } = default!;

        /// <summary>
        /// Example: git:git.example.com/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mirror_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? MirrorUrl { get; set; } = default!;

        /// <summary>
        /// Example: http://api.github.com/repos/octocat/Hello-World/hooks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://svn.github.com/octocat/Hello-World
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("svn_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SvnUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("homepage", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Homepage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Language { get; set; } = default!;

        /// <summary>
        /// Example: 9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forks_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ForksCount { get; set; } = default!;

        /// <summary>
        /// Example: 80
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stargazers_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int StargazersCount { get; set; } = default!;

        /// <summary>
        /// Example: 80
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watchers_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int WatchersCount { get; set; } = default!;

        /// <summary>
        /// Example: 108
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// The default branch of the repository.<br/>
        /// Example: master
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultBranch { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_issues_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssuesCount { get; set; } = default!;

        /// <summary>
        /// Whether this repository acts as a template that can be used to generate new repositories.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Whether issues are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasIssues { get; set; } = default!;

        /// <summary>
        /// Whether projects are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasProjects { get; set; } = default!;

        /// <summary>
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_wiki", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasWiki { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPages { get; set; } = default!;

        /// <summary>
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_downloads", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasDownloads { get; set; } = default!;

        /// <summary>
        /// Whether the repository is archived.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// Returns whether or not this repository disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Disabled { get; set; } = default!;

        /// <summary>
        /// The repository visibility: public, private, or internal.<br/>
        /// Default Value: public
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pushed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? PushedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_rebase_merge")]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temp_clone_token")]
        public string? TempCloneToken { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_squash_merge")]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// Whether to allow Auto-merge to be used on pull requests.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_auto_merge")]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_branch_on_merge")]
        public bool? DeleteBranchOnMerge { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_merge_commit")]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow forking this repo<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// Whether to require contributors to sign off on web-based commits<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscribers_count")]
        public int? SubscribersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("network_count")]
        public int? NetworkCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssues { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watchers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Watchers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("master_branch")]
        public string? MasterBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.TeamRepository? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamRepository>(
                json,
                jsonSerializerOptions);
        }

    }
}