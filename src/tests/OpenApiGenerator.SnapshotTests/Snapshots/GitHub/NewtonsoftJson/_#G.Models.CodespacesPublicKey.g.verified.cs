﻿//HintName: G.Models.CodespacesPublicKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The public key used for setting Codespaces secrets.
    /// </summary>
    public sealed partial class CodespacesPublicKey
    {
        /// <summary>
        /// The identifier for the key.
        /// <br/>Example: 1234567
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// The Base64 encoded public key.
        /// <br/>Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/user/keys/2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <br/>Example: ssh-rsa AAAAB3NzaC1yc2EAAA
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <br/>Example: 2011-01-26T19:01:12Z
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}