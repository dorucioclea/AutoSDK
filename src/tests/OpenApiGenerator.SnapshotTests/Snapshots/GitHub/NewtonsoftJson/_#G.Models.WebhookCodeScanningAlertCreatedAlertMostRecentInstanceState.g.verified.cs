﻿//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertCreatedAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertCreatedAlertMostRecentInstanceState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}