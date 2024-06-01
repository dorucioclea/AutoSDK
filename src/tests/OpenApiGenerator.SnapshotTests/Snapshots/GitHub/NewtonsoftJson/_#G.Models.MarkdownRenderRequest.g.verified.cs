﻿//HintName: G.Models.MarkdownRenderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownRenderRequest
    {
        /// <summary>
        /// The Markdown text to render in HTML.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The rendering mode.
        /// <br/>Default Value: markdown
        /// <br/>Example: markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public MarkdownRenderRequestMode? Mode { get; set; } = MarkdownRenderRequestMode.Markdown;

        /// <summary>
        /// The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}