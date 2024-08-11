﻿//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Failure,
                "skipped" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Success,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepConclusion.Cancelled,
                _ => null,
            };
        }
    }
}