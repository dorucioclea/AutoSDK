﻿//HintName: G.Models.GetUserSelfResponseUserDetailUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "users"
    /// </summary>
    public sealed partial class GetUserSelfResponseUserDetailUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Username of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetailUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username">
        /// Username of the user.
        /// </param>
        public GetUserSelfResponseUserDetailUser(
            string? id,
            string? username)
        {
            this.Id = id;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetailUser" /> class.
        /// </summary>
        public GetUserSelfResponseUserDetailUser()
        {
        }
    }
}