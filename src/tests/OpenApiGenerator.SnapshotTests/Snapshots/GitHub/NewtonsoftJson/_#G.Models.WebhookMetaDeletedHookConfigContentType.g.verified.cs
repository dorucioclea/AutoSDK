﻿//HintName: G.Models.WebhookMetaDeletedHookConfigContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMetaDeletedHookConfigContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="form")]
        Form,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMetaDeletedHookConfigContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMetaDeletedHookConfigContentType value)
        {
            return value switch
            {
                WebhookMetaDeletedHookConfigContentType.Json => "json",
                WebhookMetaDeletedHookConfigContentType.Form => "form",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMetaDeletedHookConfigContentType ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookMetaDeletedHookConfigContentType.Json,
                "form" => WebhookMetaDeletedHookConfigContentType.Form,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}