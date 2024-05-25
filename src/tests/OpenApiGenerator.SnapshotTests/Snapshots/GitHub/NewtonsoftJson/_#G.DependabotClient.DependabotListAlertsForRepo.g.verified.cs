﻿//HintName: G.DependabotClient.DependabotListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="scope"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotListAlertsForRepoAsync(
            string owner,
            string repo,
            string state,
            string severity,
            string ecosystem,
            string package,
            string manifest,
            DependabotListAlertsForRepoScope scope,
            DependabotListAlertsForRepoSort sort,
            DependabotListAlertsForRepoDirection direction,
            int page,
            int perPage,
            string before,
            string after,
            int first,
            int last,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var scopeValue = scope switch
            {
                DependabotListAlertsForRepoScope.Development => "development",
                DependabotListAlertsForRepoScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                DependabotListAlertsForRepoSort.Created => "created",
                DependabotListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                DependabotListAlertsForRepoDirection.Asc => "asc",
                DependabotListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/dependabot/alerts?state={state}&severity={severity}&ecosystem={ecosystem}&package={package}&manifest={manifest}&scope={scopeValue}&sort={sortValue}&direction={directionValue}&page={page}&per_page={perPage}&before={before}&after={after}&first={first}&last={last}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}