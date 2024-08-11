﻿//HintName: G.Models.ApiOverview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Api Overview
    /// </summary>
    public sealed partial class ApiOverview
    {
        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiable_password_authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiablePasswordAuthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_key_fingerprints")]
        public global::G.ApiOverviewSshKeyFingerprints? SshKeyFingerprints { get; set; }

        /// <summary>
        /// Example: [ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_keys")]
        public global::System.Collections.Generic.IList<string>? SshKeys { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<string>? Hooks { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_enterprise_importer")]
        public global::System.Collections.Generic.IList<string>? GithubEnterpriseImporter { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        public global::System.Collections.Generic.IList<string>? Web { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public global::System.Collections.Generic.IList<string>? Api { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::System.Collections.Generic.IList<string>? Git { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<string>? Packages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<string>? Pages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importer")]
        public global::System.Collections.Generic.IList<string>? Importer { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<string>? Actions { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_macos")]
        public global::System.Collections.Generic.IList<string>? ActionsMacos { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot")]
        public global::System.Collections.Generic.IList<string>? Dependabot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::G.ApiOverviewDomains? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}