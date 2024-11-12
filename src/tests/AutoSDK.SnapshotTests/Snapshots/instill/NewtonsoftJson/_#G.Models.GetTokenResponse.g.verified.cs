﻿//HintName: G.Models.GetTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetTokenResponse contains the requested token.
    /// </summary>
    public sealed partial class GetTokenResponse
    {
        /// <summary>
        /// The API token resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public global::G.ApiToken? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The API token resource.<br/>
        /// Included only in responses
        /// </param>
        public GetTokenResponse(
            global::G.ApiToken? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResponse" /> class.
        /// </summary>
        public GetTokenResponse()
        {
        }
    }
}