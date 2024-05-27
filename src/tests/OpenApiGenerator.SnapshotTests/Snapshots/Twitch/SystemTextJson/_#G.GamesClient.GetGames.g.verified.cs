﻿//HintName: G.GamesClient.GetGames.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class GamesClient
    {
        /// <summary>
        /// Gets information about specified games.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="igdbId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetGamesResponse> GetGamesAsync(
            global::System.Collections.Generic.IList<string> id,
            global::System.Collections.Generic.IList<string> name,
            global::System.Collections.Generic.IList<string> igdbId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/games?{string.Join("&", id.Select(static x => $"id={x}"))}&{string.Join("&", name.Select(static x => $"name={x}"))}&{string.Join("&", igdbId.Select(static x => $"igdbId={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetGamesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}