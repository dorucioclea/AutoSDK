﻿//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRejectedWorkflowRunActorType
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewRejectedWorkflowRunActorType.User => "User",
                WebhookDeploymentReviewRejectedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunActorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRejectedWorkflowRunActorType.Bot,
                "User" => WebhookDeploymentReviewRejectedWorkflowRunActorType.User,
                "Organization" => WebhookDeploymentReviewRejectedWorkflowRunActorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}