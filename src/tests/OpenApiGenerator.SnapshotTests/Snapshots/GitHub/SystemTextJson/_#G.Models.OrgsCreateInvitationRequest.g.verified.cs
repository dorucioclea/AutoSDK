﻿//HintName: G.Models.OrgsCreateInvitationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateInvitationRequest
    {
        /// <summary>
        /// **Required unless you provide `email`**. GitHub user ID for the person you are inviting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitee_id")]
        public int InviteeId { get; set; }

        /// <summary>
        /// **Required unless you provide `invitee_id`**. Email address of the person you are inviting, which can be an existing GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The role for the new member. 
        ///  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.  
        ///  * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.  
        ///  * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization. 
        ///  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.
        /// <br/>Default Value: direct_member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OrgsCreateInvitationRequestRoleJsonConverter))]
        public OrgsCreateInvitationRequestRole? Role { get; set; } = OrgsCreateInvitationRequestRole.DirectMember;

        /// <summary>
        /// Specify IDs for the teams you want to invite new members to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<int>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}