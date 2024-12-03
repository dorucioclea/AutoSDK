﻿//HintName: G.Models.ReactionsCreateForCommitCommentRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the commit comment.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsCreateForCommitCommentRequestContent
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
    public static class ReactionsCreateForCommitCommentRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForCommitCommentRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForCommitCommentRequestContent.Plus1 => "+1",
                ReactionsCreateForCommitCommentRequestContent.Minus1 => "-1",
                ReactionsCreateForCommitCommentRequestContent.Laugh => "laugh",
                ReactionsCreateForCommitCommentRequestContent.Confused => "confused",
                ReactionsCreateForCommitCommentRequestContent.Heart => "heart",
                ReactionsCreateForCommitCommentRequestContent.Hooray => "hooray",
                ReactionsCreateForCommitCommentRequestContent.Rocket => "rocket",
                ReactionsCreateForCommitCommentRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForCommitCommentRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForCommitCommentRequestContent.Plus1,
                "-1" => ReactionsCreateForCommitCommentRequestContent.Minus1,
                "laugh" => ReactionsCreateForCommitCommentRequestContent.Laugh,
                "confused" => ReactionsCreateForCommitCommentRequestContent.Confused,
                "heart" => ReactionsCreateForCommitCommentRequestContent.Heart,
                "hooray" => ReactionsCreateForCommitCommentRequestContent.Hooray,
                "rocket" => ReactionsCreateForCommitCommentRequestContent.Rocket,
                "eyes" => ReactionsCreateForCommitCommentRequestContent.Eyes,
                _ => null,
            };
        }
    }
}