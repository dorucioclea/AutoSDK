﻿//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeMergeMethod.Rebase,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}