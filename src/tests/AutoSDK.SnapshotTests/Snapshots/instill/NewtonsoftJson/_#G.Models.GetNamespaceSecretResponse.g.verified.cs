﻿//HintName: G.Models.GetNamespaceSecretResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceSecretResponse contains the requested secret.
    /// </summary>
    public sealed partial class GetNamespaceSecretResponse
    {
        /// <summary>
        /// The secret resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public global::G.Secret? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The secret resource.
        /// </param>
        public GetNamespaceSecretResponse(
            global::G.Secret? secret)
        {
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceSecretResponse" /> class.
        /// </summary>
        public GetNamespaceSecretResponse()
        {
        }
    }
}