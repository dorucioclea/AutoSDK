﻿//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentEditedPullRequestLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksComments Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksCommits Commits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksHtml Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksIssue Issue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksReviewComment ReviewComment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksReviewComments ReviewComments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksSelf Self { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewCommentEditedPullRequestLinksStatuses Statuses { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPullRequestReviewCommentEditedPullRequestLinks? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPullRequestReviewCommentEditedPullRequestLinks>(
                json,
                jsonSerializerOptions);
        }

    }
}