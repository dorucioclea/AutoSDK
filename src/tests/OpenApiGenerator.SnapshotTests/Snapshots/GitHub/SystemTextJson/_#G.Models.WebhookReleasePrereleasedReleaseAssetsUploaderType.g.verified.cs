﻿//HintName: G.Models.WebhookReleasePrereleasedReleaseAssetsUploaderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookReleasePrereleasedReleaseAssetsUploaderType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleasePrereleasedReleaseAssetsUploaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleasePrereleasedReleaseAssetsUploaderType value)
        {
            return value switch
            {
                WebhookReleasePrereleasedReleaseAssetsUploaderType.Bot => "Bot",
                WebhookReleasePrereleasedReleaseAssetsUploaderType.User => "User",
                WebhookReleasePrereleasedReleaseAssetsUploaderType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleasePrereleasedReleaseAssetsUploaderType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookReleasePrereleasedReleaseAssetsUploaderType.Bot,
                "User" => WebhookReleasePrereleasedReleaseAssetsUploaderType.User,
                "Organization" => WebhookReleasePrereleasedReleaseAssetsUploaderType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}