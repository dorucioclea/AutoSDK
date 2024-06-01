﻿//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, `waiting`, or `completed`.
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobCompletedWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobStatus.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobCompletedWorkflowJobStatus.Queued,
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobStatus.InProgress,
                "completed" => WebhookWorkflowJobCompletedWorkflowJobStatus.Completed,
                "waiting" => WebhookWorkflowJobCompletedWorkflowJobStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}