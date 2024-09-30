﻿//HintName: G.Models.CitationParametersStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The citation style to be used in summary.<br/>
    /// Can be one of:<br/>
    /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ...<br/>
    /// * `none` - Citations removed from text.<br/>
    /// * `html` - Citation formatted as url like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`.<br/>
    /// * `markdown` - Formatted as `[text_pattern](url_pattern)`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CitationParametersStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// \[1\], \[2\] ...
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="numeric")]
        Numeric,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationParametersStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationParametersStyle value)
        {
            return value switch
            {
                CitationParametersStyle.None => "none",
                CitationParametersStyle.Numeric => "numeric",
                CitationParametersStyle.Html => "html",
                CitationParametersStyle.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationParametersStyle? ToEnum(string value)
        {
            return value switch
            {
                "none" => CitationParametersStyle.None,
                "numeric" => CitationParametersStyle.Numeric,
                "html" => CitationParametersStyle.Html,
                "markdown" => CitationParametersStyle.Markdown,
                _ => null,
            };
        }
    }
}