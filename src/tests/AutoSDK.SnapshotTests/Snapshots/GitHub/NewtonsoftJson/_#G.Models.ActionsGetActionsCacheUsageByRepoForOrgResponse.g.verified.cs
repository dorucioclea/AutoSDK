﻿//HintName: G.Models.ActionsGetActionsCacheUsageByRepoForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetActionsCacheUsageByRepoForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_cache_usages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActionsCacheUsageByRepository> RepositoryCacheUsages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetActionsCacheUsageByRepoForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositoryCacheUsages"></param>
        public ActionsGetActionsCacheUsageByRepoForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ActionsCacheUsageByRepository> repositoryCacheUsages)
        {
            this.TotalCount = totalCount;
            this.RepositoryCacheUsages = repositoryCacheUsages ?? throw new global::System.ArgumentNullException(nameof(repositoryCacheUsages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetActionsCacheUsageByRepoForOrgResponse" /> class.
        /// </summary>
        public ActionsGetActionsCacheUsageByRepoForOrgResponse()
        {
        }
    }
}