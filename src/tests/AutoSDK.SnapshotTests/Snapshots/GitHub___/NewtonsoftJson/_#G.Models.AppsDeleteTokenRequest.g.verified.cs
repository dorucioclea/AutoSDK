﻿//HintName: G.Models.AppsDeleteTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsDeleteTokenRequest
    {
        /// <summary>
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsDeleteTokenRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </param>
        public AppsDeleteTokenRequest(
            string accessToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsDeleteTokenRequest" /> class.
        /// </summary>
        public AppsDeleteTokenRequest()
        {
        }
    }
}