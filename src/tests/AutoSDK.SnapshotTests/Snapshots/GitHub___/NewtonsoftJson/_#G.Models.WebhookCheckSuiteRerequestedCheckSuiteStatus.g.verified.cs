﻿//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRerequestedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRerequestedCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteStatus value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested => "requested",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested,
                "in_progress" => WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress,
                "completed" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed,
                "queued" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued,
                _ => null,
            };
        }
    }
}