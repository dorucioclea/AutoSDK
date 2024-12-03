﻿//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the completed check run. This value will be `null` until the check run has completed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedCheckRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedCheckRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedCheckRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedCheckRunConclusion.Success => "success",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Failure => "failure",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral => "neutral",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Stale => "stale",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedCheckRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentStatusCreatedCheckRunConclusion.Success,
                "failure" => WebhookDeploymentStatusCreatedCheckRunConclusion.Failure,
                "neutral" => WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentStatusCreatedCheckRunConclusion.Stale,
                "skipped" => WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped,
                _ => null,
            };
        }
    }
}