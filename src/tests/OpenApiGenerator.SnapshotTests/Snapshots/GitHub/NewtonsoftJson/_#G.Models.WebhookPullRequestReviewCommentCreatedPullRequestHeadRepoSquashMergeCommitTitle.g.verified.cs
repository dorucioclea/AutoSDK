﻿//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_OR_PR_TITLE")]
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}