﻿//HintName: G.Models.PullRequestLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestLinks
    {
        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Comments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Commits { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Statuses { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Html { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Issue { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link ReviewComments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link ReviewComment { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestLinks" /> class.
        /// </summary>
        /// <param name="comments">
        /// Hypermedia Link
        /// </param>
        /// <param name="commits">
        /// Hypermedia Link
        /// </param>
        /// <param name="statuses">
        /// Hypermedia Link
        /// </param>
        /// <param name="html">
        /// Hypermedia Link
        /// </param>
        /// <param name="issue">
        /// Hypermedia Link
        /// </param>
        /// <param name="reviewComments">
        /// Hypermedia Link
        /// </param>
        /// <param name="reviewComment">
        /// Hypermedia Link
        /// </param>
        /// <param name="self">
        /// Hypermedia Link
        /// </param>
        public PullRequestLinks(
            global::G.Link comments,
            global::G.Link commits,
            global::G.Link statuses,
            global::G.Link html,
            global::G.Link issue,
            global::G.Link reviewComments,
            global::G.Link reviewComment,
            global::G.Link self)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.ReviewComments = reviewComments ?? throw new global::System.ArgumentNullException(nameof(reviewComments));
            this.ReviewComment = reviewComment ?? throw new global::System.ArgumentNullException(nameof(reviewComment));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestLinks" /> class.
        /// </summary>
        public PullRequestLinks()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PullRequestLinks? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullRequestLinks>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PullRequestLinks?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PullRequestLinks?>(serializer.Deserialize<global::G.PullRequestLinks>(jsonReader));
        }

    }
}