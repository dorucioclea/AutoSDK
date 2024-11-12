﻿//HintName: G.Models.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest
    {
        /// <summary>
        /// List of repository IDs to enable for GitHub Actions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_repository_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> SelectedRepositoryIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs to enable for GitHub Actions.
        /// </param>
        public ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest()
        {
        }
    }
}