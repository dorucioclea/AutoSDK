﻿//HintName: G.Models.ActionsUpdateSelfHostedRunnerGroupForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateSelfHostedRunnerGroupForOrgRequest
    {
        /// <summary>
        /// Name of the runner group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allows_public_repositories")]
        public bool? AllowsPublicRepositories { get; set; }

        /// <summary>
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restricted_to_workflows")]
        public bool? RestrictedToWorkflows { get; set; }

        /// <summary>
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_workflows")]
        public global::System.Collections.Generic.IList<string>? SelectedWorkflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateSelfHostedRunnerGroupForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories.
        /// </param>
        /// <param name="allowsPublicRepositories">
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        public ActionsUpdateSelfHostedRunnerGroupForOrgRequest(
            string name,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? visibility,
            bool? allowsPublicRepositories,
            bool? restrictedToWorkflows,
            global::System.Collections.Generic.IList<string>? selectedWorkflows)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.AllowsPublicRepositories = allowsPublicRepositories;
            this.RestrictedToWorkflows = restrictedToWorkflows;
            this.SelectedWorkflows = selectedWorkflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateSelfHostedRunnerGroupForOrgRequest" /> class.
        /// </summary>
        public ActionsUpdateSelfHostedRunnerGroupForOrgRequest()
        {
        }
    }
}