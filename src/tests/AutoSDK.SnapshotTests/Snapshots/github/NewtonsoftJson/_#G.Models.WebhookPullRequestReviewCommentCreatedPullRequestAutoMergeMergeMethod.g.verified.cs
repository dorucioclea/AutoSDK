﻿//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squash")]
        Squash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rebase")]
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewCommentCreatedPullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}