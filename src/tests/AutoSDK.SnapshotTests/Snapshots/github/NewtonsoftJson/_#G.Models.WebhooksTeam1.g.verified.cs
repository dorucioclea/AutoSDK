﻿//HintName: G.Models.WebhooksTeam1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class WebhooksTeam1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Description of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.WebhooksTeam1Parent? Parent { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.WebhooksTeam1Privacy? Privacy { get; set; }

        /// <summary>
        /// Whether team members will receive notifications when their team is @mentioned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public global::G.WebhooksTeam1NotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories_url")]
        public string? RepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// URL for the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksTeam1" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="description">
        /// Description of the team
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the team
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="name">
        /// Name of the team
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="parent"></param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories
        /// </param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting">
        /// Whether team members will receive notifications when their team is @mentioned
        /// </param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="slug"></param>
        /// <param name="url">
        /// URL for the team
        /// </param>
        public WebhooksTeam1(
            int id,
            string name,
            bool? deleted,
            string? description,
            string? htmlUrl,
            string? membersUrl,
            string? nodeId,
            global::G.WebhooksTeam1Parent? parent,
            string? permission,
            global::G.WebhooksTeam1Privacy? privacy,
            global::G.WebhooksTeam1NotificationSetting? notificationSetting,
            string? repositoriesUrl,
            string? slug,
            string? url)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Deleted = deleted;
            this.Description = description;
            this.HtmlUrl = htmlUrl;
            this.MembersUrl = membersUrl;
            this.NodeId = nodeId;
            this.Parent = parent;
            this.Permission = permission;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.RepositoriesUrl = repositoriesUrl;
            this.Slug = slug;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksTeam1" /> class.
        /// </summary>
        public WebhooksTeam1()
        {
        }
    }
}