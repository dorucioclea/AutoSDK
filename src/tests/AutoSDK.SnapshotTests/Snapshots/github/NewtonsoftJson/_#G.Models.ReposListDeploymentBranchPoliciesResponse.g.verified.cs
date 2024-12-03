﻿//HintName: G.Models.ReposListDeploymentBranchPoliciesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposListDeploymentBranchPoliciesResponse
    {
        /// <summary>
        /// The number of deployment branch policies for the environment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_policies", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DeploymentBranchPolicy> BranchPolicies { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListDeploymentBranchPoliciesResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of deployment branch policies for the environment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="branchPolicies"></param>
        public ReposListDeploymentBranchPoliciesResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.DeploymentBranchPolicy> branchPolicies)
        {
            this.TotalCount = totalCount;
            this.BranchPolicies = branchPolicies ?? throw new global::System.ArgumentNullException(nameof(branchPolicies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListDeploymentBranchPoliciesResponse" /> class.
        /// </summary>
        public ReposListDeploymentBranchPoliciesResponse()
        {
        }
    }
}