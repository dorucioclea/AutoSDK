﻿//HintName: G.Models.UpdateUserMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateUserMembershipResponse contains the updated membership.
    /// </summary>
    public sealed partial class UpdateUserMembershipResponse
    {
        /// <summary>
        /// The updated membership resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.UserMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}