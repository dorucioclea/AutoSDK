﻿//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRequestedCheckSuiteAppOwnerType
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppOwnerType value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Bot => "Bot",
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User => "User",
                WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Bot,
                "User" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.User,
                "Organization" => WebhookCheckSuiteRequestedCheckSuiteAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}