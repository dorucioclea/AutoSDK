﻿//HintName: G.Models.GetGuestStarInvitesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGuestStarInvitesResponse
    {
        /// <summary>
        /// A list of invite objects describing the invited user as well as their ready status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GuestStarInvite> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarInvitesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of invite objects describing the invited user as well as their ready status.
        /// </param>
        public GetGuestStarInvitesResponse(
            global::System.Collections.Generic.IList<global::G.GuestStarInvite> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarInvitesResponse" /> class.
        /// </summary>
        public GetGuestStarInvitesResponse()
        {
        }
    }
}