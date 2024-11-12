﻿//HintName: G.Models.UserRoleUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserRoleUpdateRequest
    {
        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserRoleUpdateRequestRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        public UserRoleUpdateRequest(
            global::G.UserRoleUpdateRequestRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        public UserRoleUpdateRequest()
        {
        }
    }
}