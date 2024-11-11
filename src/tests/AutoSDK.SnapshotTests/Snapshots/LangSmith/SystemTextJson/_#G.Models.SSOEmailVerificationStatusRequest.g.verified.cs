﻿//HintName: G.Models.SSOEmailVerificationStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOEmailVerificationStatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SamlProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SSOEmailVerificationStatusRequest(
            string email,
            global::System.Guid samlProviderId)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.SamlProviderId = samlProviderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusRequest" /> class.
        /// </summary>
        public SSOEmailVerificationStatusRequest()
        {
        }
    }
}