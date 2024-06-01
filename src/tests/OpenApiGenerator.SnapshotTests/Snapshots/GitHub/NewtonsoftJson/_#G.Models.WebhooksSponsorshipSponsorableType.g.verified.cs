﻿//HintName: G.Models.WebhooksSponsorshipSponsorableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksSponsorshipSponsorableType
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
    public static class WebhooksSponsorshipSponsorableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksSponsorshipSponsorableType value)
        {
            return value switch
            {
                WebhooksSponsorshipSponsorableType.Bot => "Bot",
                WebhooksSponsorshipSponsorableType.User => "User",
                WebhooksSponsorshipSponsorableType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksSponsorshipSponsorableType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksSponsorshipSponsorableType.Bot,
                "User" => WebhooksSponsorshipSponsorableType.User,
                "Organization" => WebhooksSponsorshipSponsorableType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}