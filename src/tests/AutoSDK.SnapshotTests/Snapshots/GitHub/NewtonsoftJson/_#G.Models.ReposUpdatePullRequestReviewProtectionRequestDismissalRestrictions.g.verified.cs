﻿//HintName: G.Models.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.
    /// </summary>
    public sealed partial class ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions
    {
        /// <summary>
        /// The list of user `login`s with dismissal access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// The list of team `slug`s with dismissal access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// The list of app `slug`s with dismissal access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s with dismissal access
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s with dismissal access
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s with dismissal access
        /// </param>
        public ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions(
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions" /> class.
        /// </summary>
        public ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions()
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
        public static global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions?>(serializer.Deserialize<global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions>(jsonReader));
        }

    }
}