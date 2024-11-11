﻿//HintName: G.Models.WebhookTeamEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the team if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookTeamEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.WebhookTeamEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookTeamEditedChangesName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.WebhookTeamEditedChangesPrivacy? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public global::G.WebhookTeamEditedChangesNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.WebhookTeamEditedChangesRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="repository"></param>
        public WebhookTeamEditedChanges(
            global::G.WebhookTeamEditedChangesDescription? description,
            global::G.WebhookTeamEditedChangesName? name,
            global::G.WebhookTeamEditedChangesPrivacy? privacy,
            global::G.WebhookTeamEditedChangesNotificationSetting? notificationSetting,
            global::G.WebhookTeamEditedChangesRepository? repository)
        {
            this.Description = description;
            this.Name = name;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        public WebhookTeamEditedChanges()
        {
        }
    }
}