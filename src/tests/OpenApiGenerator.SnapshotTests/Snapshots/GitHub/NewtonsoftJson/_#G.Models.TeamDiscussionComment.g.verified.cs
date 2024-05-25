﻿//HintName: G.Models.TeamDiscussionComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reply to a discussion within a team.
    /// </summary>
    public sealed partial class TeamDiscussionComment
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// The main text of the comment.
        /// <br/>Example: I agree with this suggestion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// <br/>Example: &lt;p&gt;Do you like apples?&lt;/p&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyHtml { get; set; } = default!;

        /// <summary>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
        /// <br/>Example: 0307116bbf7ced493b8d8a346c650b71
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string BodyVersion { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_edited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? LastEditedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/2403582/discussions/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/orgs/github/teams/justice-league/discussions/1/comments/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDIxOlRlYW1EaXNjdXNzaW9uQ29tbWVudDE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The unique sequence number of a team discussion comment.
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/organizations/1/team/2403582/discussions/1/comments/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}