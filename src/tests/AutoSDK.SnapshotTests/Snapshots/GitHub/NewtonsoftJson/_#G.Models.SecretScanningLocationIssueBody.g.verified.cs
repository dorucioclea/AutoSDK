﻿//HintName: G.Models.SecretScanningLocationIssueBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an 'issue_body' secret scanning location type. This location type shows that a secret was detected in the body of an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueBody
    {
        /// <summary>
        /// The API URL to get the issue where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347</example>
        [global::Newtonsoft.Json.JsonProperty("issue_body_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueBodyUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueBody" /> class.
        /// </summary>
        /// <param name="issueBodyUrl">
        /// The API URL to get the issue where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </param>
        public SecretScanningLocationIssueBody(
            string issueBodyUrl)
        {
            this.IssueBodyUrl = issueBodyUrl ?? throw new global::System.ArgumentNullException(nameof(issueBodyUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueBody" /> class.
        /// </summary>
        public SecretScanningLocationIssueBody()
        {
        }
    }
}