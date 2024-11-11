﻿//HintName: G.Models.ReposCreateDeployKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeployKeyRequest
    {
        /// <summary>
        /// A name for the key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The contents of the key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// If `true`, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.  <br/>
        ///   <br/>
        /// Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see "[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)" and "[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeployKeyRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// A name for the key.
        /// </param>
        /// <param name="key">
        /// The contents of the key.
        /// </param>
        /// <param name="readOnly">
        /// If `true`, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.  <br/>
        ///   <br/>
        /// Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see "[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)" and "[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/)."
        /// </param>
        public ReposCreateDeployKeyRequest(
            string key,
            string? title,
            bool? readOnly)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Title = title;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeployKeyRequest" /> class.
        /// </summary>
        public ReposCreateDeployKeyRequest()
        {
        }
    }
}