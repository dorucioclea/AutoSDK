﻿//HintName: G.Models.OrgsUpdateMembershipForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdateMembershipForAuthenticatedUserRequest
    {
        /// <summary>
        /// The state that the membership should be in. Only `"active"` will be accepted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateMembershipForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state that the membership should be in. Only `"active"` will be accepted.
        /// </param>
        public OrgsUpdateMembershipForAuthenticatedUserRequest(
            global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState state)
        {
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateMembershipForAuthenticatedUserRequest" /> class.
        /// </summary>
        public OrgsUpdateMembershipForAuthenticatedUserRequest()
        {
        }
    }
}