﻿//HintName: G.Models.ProtectedBranchPullRequestReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Protected Branch Pull Request Review
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReview
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/dismissal_restrictions
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/dismissal_restrictions</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_restrictions")]
        public global::G.ProtectedBranchPullRequestReviewDismissalRestrictions? DismissalRestrictions { get; set; }

        /// <summary>
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_pull_request_allowances")]
        public global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances? BypassPullRequestAllowances { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("dismiss_stale_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public bool DismissStaleReviews { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("require_code_owner_reviews", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireCodeOwnerReviews { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("require_last_push_approval")]
        public bool? RequireLastPushApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReview" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/dismissal_restrictions
        /// </param>
        /// <param name="dismissalRestrictions"></param>
        /// <param name="bypassPullRequestAllowances">
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </param>
        /// <param name="dismissStaleReviews">
        /// Example: true
        /// </param>
        /// <param name="requireCodeOwnerReviews">
        /// Example: true
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// Example: 2
        /// </param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        public ProtectedBranchPullRequestReview(
            bool dismissStaleReviews,
            bool requireCodeOwnerReviews,
            string? url,
            global::G.ProtectedBranchPullRequestReviewDismissalRestrictions? dismissalRestrictions,
            global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances? bypassPullRequestAllowances,
            int? requiredApprovingReviewCount,
            bool? requireLastPushApproval)
        {
            this.DismissStaleReviews = dismissStaleReviews;
            this.RequireCodeOwnerReviews = requireCodeOwnerReviews;
            this.Url = url;
            this.DismissalRestrictions = dismissalRestrictions;
            this.BypassPullRequestAllowances = bypassPullRequestAllowances;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequireLastPushApproval = requireLastPushApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReview" /> class.
        /// </summary>
        public ProtectedBranchPullRequestReview()
        {
        }
    }
}