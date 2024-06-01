﻿//HintName: G.Models.WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle
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
    public static class WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestConvertedToDraftPullRequestMergeCommitTitle.MERGEMESSAGE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}