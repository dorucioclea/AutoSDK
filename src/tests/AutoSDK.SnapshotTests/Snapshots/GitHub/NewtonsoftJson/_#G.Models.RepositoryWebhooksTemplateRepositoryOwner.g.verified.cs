﻿//HintName: G.Models.RepositoryWebhooksTemplateRepositoryOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryWebhooksTemplateRepositoryOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url")]
        public string? ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin")]
        public bool? SiteAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryWebhooksTemplateRepositoryOwner" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="gravatarId"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="type"></param>
        /// <param name="siteAdmin"></param>
        public RepositoryWebhooksTemplateRepositoryOwner(
            string? login,
            int? id,
            string? nodeId,
            string? avatarUrl,
            string? gravatarId,
            string? url,
            string? htmlUrl,
            string? followersUrl,
            string? followingUrl,
            string? gistsUrl,
            string? starredUrl,
            string? subscriptionsUrl,
            string? organizationsUrl,
            string? reposUrl,
            string? eventsUrl,
            string? receivedEventsUrl,
            string? type,
            bool? siteAdmin)
        {
            this.Login = login;
            this.Id = id;
            this.NodeId = nodeId;
            this.AvatarUrl = avatarUrl;
            this.GravatarId = gravatarId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.FollowersUrl = followersUrl;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.OrganizationsUrl = organizationsUrl;
            this.ReposUrl = reposUrl;
            this.EventsUrl = eventsUrl;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.Type = type;
            this.SiteAdmin = siteAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryWebhooksTemplateRepositoryOwner" /> class.
        /// </summary>
        public RepositoryWebhooksTemplateRepositoryOwner()
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
        public static global::G.RepositoryWebhooksTemplateRepositoryOwner? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryWebhooksTemplateRepositoryOwner>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryWebhooksTemplateRepositoryOwner?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryWebhooksTemplateRepositoryOwner?>(serializer.Deserialize<global::G.RepositoryWebhooksTemplateRepositoryOwner>(jsonReader));
        }

    }
}