﻿//HintName: G.Models.WebhookProjectsV2ProjectClosedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectsV2ProjectClosedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ProjectClosedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ProjectClosedAction value)
        {
            return value switch
            {
                WebhookProjectsV2ProjectClosedAction.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ProjectClosedAction ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookProjectsV2ProjectClosedAction.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}