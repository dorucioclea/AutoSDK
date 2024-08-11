﻿//HintName: G.Models.WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestLabeledPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}