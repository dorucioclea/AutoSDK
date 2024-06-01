﻿//HintName: G.Models.WebhooksPullRequest5AutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5AutoMergeMergeMethod
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
    public static class WebhooksPullRequest5AutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhooksPullRequest5AutoMergeMergeMethod.Merge => "merge",
                WebhooksPullRequest5AutoMergeMergeMethod.Squash => "squash",
                WebhooksPullRequest5AutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AutoMergeMergeMethod ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhooksPullRequest5AutoMergeMergeMethod.Merge,
                "squash" => WebhooksPullRequest5AutoMergeMergeMethod.Squash,
                "rebase" => WebhooksPullRequest5AutoMergeMergeMethod.Rebase,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}