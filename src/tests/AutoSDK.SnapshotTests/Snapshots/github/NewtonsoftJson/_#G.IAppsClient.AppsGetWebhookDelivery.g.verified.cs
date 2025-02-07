﻿//HintName: G.IAppsClient.AppsGetWebhookDelivery.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get a delivery for an app webhook<br/>
        /// Returns a delivery for the webhook configured for a GitHub App.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HookDelivery> AppsGetWebhookDeliveryAsync(
            int deliveryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}