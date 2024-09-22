﻿//HintName: G.Models.UserMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A user membership defines the relationship between a user and an<br/>
    /// organization they belong to.
    /// </summary>
    public sealed partial class UserMembership
    {
        /// <summary>
        /// The resource name of the membership, which allows its access by user and<br/>
        /// organization ID.<br/>
        /// - Format: `users/{user.id}/memberships/{organization.id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Role of the user in the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// State of the membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MembershipStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MembershipState State { get; set; }

        /// <summary>
        /// User information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}