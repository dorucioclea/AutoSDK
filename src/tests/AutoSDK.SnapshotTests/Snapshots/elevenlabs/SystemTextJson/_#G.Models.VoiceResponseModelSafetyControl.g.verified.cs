﻿//HintName: G.Models.VoiceResponseModelSafetyControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceResponseModelSafetyControl
    {
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        BAN,
        /// <summary>
        /// 
        /// </summary>
        CAPTCHA,
        /// <summary>
        /// 
        /// </summary>
        CAPTCHAANDMODERATION,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelSafetyControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelSafetyControl value)
        {
            return value switch
            {
                VoiceResponseModelSafetyControl.NONE => "NONE",
                VoiceResponseModelSafetyControl.BAN => "BAN",
                VoiceResponseModelSafetyControl.CAPTCHA => "CAPTCHA",
                VoiceResponseModelSafetyControl.CAPTCHAANDMODERATION => "CAPTCHA_AND_MODERATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelSafetyControl? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => VoiceResponseModelSafetyControl.NONE,
                "BAN" => VoiceResponseModelSafetyControl.BAN,
                "CAPTCHA" => VoiceResponseModelSafetyControl.CAPTCHA,
                "CAPTCHA_AND_MODERATION" => VoiceResponseModelSafetyControl.CAPTCHAANDMODERATION,
                _ => null,
            };
        }
    }
}