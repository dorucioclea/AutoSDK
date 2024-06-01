﻿//HintName: G.Models.CodespacesCreateWithRepoForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCreateWithRepoForAuthenticatedUserRequest
    {
        /// <summary>
        /// Git ref (typically a branch name) for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geo")]
        public CodespacesCreateWithRepoForAuthenticatedUserRequestGeo? Geo { get; set; }

        /// <summary>
        /// IP for location auto-detection when proxying a request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// Machine type to use for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machine")]
        public string? Machine { get; set; }

        /// <summary>
        /// Path to devcontainer.json config to use for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devcontainer_path")]
        public string? DevcontainerPath { get; set; }

        /// <summary>
        /// Whether to authorize requested permissions from devcontainer.json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_repo_permissions_opt_out")]
        public bool MultiRepoPermissionsOptOut { get; set; }

        /// <summary>
        /// Working directory for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Time in minutes before codespace stops from inactivity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_timeout_minutes")]
        public int IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// Display name for this codespace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention_period_minutes")]
        public int RetentionPeriodMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}