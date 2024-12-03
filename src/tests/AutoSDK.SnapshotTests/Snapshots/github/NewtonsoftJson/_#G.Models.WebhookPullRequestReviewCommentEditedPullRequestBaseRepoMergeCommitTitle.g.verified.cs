﻿//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_MESSAGE")]
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}