﻿//HintName: G.Models.WebhookReleasePrereleasedReleaseAssetUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookReleasePrereleasedReleaseAssetUploaderType
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
    public static class WebhookReleasePrereleasedReleaseAssetUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedReleaseAssetUploaderType value)
        {
            return value switch
            {
                WebhookReleasePrereleasedReleaseAssetUploaderType.Bot => "Bot",
                WebhookReleasePrereleasedReleaseAssetUploaderType.User => "User",
                WebhookReleasePrereleasedReleaseAssetUploaderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedReleaseAssetUploaderType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookReleasePrereleasedReleaseAssetUploaderType.Bot,
                "User" => WebhookReleasePrereleasedReleaseAssetUploaderType.User,
                "Organization" => WebhookReleasePrereleasedReleaseAssetUploaderType.Organization,
                _ => null,
            };
        }
    }
}