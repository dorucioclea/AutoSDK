﻿//HintName: G.Models.ReactionsListForIssueCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsListForIssueCommentContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+1")]
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-1")]
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confused")]
        Confused,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hooray")]
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rocket")]
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eyes")]
        Eyes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsListForIssueCommentContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForIssueCommentContent value)
        {
            return value switch
            {
                ReactionsListForIssueCommentContent.Plus1 => "+1",
                ReactionsListForIssueCommentContent.Minus1 => "-1",
                ReactionsListForIssueCommentContent.Laugh => "laugh",
                ReactionsListForIssueCommentContent.Confused => "confused",
                ReactionsListForIssueCommentContent.Heart => "heart",
                ReactionsListForIssueCommentContent.Hooray => "hooray",
                ReactionsListForIssueCommentContent.Rocket => "rocket",
                ReactionsListForIssueCommentContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForIssueCommentContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForIssueCommentContent.Plus1,
                "-1" => ReactionsListForIssueCommentContent.Minus1,
                "laugh" => ReactionsListForIssueCommentContent.Laugh,
                "confused" => ReactionsListForIssueCommentContent.Confused,
                "heart" => ReactionsListForIssueCommentContent.Heart,
                "hooray" => ReactionsListForIssueCommentContent.Hooray,
                "rocket" => ReactionsListForIssueCommentContent.Rocket,
                "eyes" => ReactionsListForIssueCommentContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}