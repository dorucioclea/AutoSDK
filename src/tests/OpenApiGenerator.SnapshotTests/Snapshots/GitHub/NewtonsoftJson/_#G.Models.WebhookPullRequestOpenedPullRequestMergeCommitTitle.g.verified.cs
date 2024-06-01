﻿//HintName: G.Models.WebhookPullRequestOpenedPullRequestMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestOpenedPullRequestMergeCommitTitle
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
    public static class WebhookPullRequestOpenedPullRequestMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestOpenedPullRequestMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestOpenedPullRequestMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestOpenedPullRequestMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestOpenedPullRequestMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestOpenedPullRequestMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestOpenedPullRequestMergeCommitTitle.MERGEMESSAGE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}