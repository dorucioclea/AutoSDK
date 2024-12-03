﻿//HintName: G.IPlaygroundSettingsClient.DeletePlaygroundSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Delete Playground Settings<br/>
        /// Delete playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}