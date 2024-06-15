﻿//HintName: G.Models.RunStreamEventVariant6Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant6Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.incomplete")]
        ThreadRunIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant6EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant6Event value)
        {
            return value switch
            {
                RunStreamEventVariant6Event.ThreadRunIncomplete => "thread.run.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant6Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.incomplete" => RunStreamEventVariant6Event.ThreadRunIncomplete,
                _ => null,
            };
        }
    }
}