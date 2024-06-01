﻿//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewApprovedWorkflowRunActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewApprovedWorkflowRunActorType.User => "User",
                WebhookDeploymentReviewApprovedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunActorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewApprovedWorkflowRunActorType.Bot,
                "User" => WebhookDeploymentReviewApprovedWorkflowRunActorType.User,
                "Organization" => WebhookDeploymentReviewApprovedWorkflowRunActorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}