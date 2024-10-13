﻿//HintName: G.EventSubClient.GetEventsubSubscriptions.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        partial void PrepareGetEventsubSubscriptionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.GetEventsubSubscriptionsStatus? status,
            ref global::G.GetEventsubSubscriptionsType? type,
            ref string? userId,
            ref string? after);
        partial void PrepareGetEventsubSubscriptionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GetEventsubSubscriptionsStatus? status,
            global::G.GetEventsubSubscriptionsType? type,
            string? userId,
            string? after);
        partial void ProcessGetEventsubSubscriptionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetEventsubSubscriptionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// __Authorization:__<br/>
        /// If you use [Webhooks](https://dev.twitch.tv/docs/eventsub/handling-webhook-events) or [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.<br/>
        /// __Request Query Parameters:__<br/>
        /// Use the _status_, _type_, and _user\_id_ query parameters to filter the list of subscriptions that are returned. The filters are mutually exclusive; the request fails if you specify more than one filter.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetEventSubSubscriptionsResponse> GetEventsubSubscriptionsAsync(
            global::G.GetEventsubSubscriptionsStatus? status = default,
            global::G.GetEventsubSubscriptionsType? type = default,
            string? userId = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetEventsubSubscriptionsArguments(
                httpClient: _httpClient,
                status: ref status,
                type: ref type,
                userId: ref userId,
                after: ref after);

            var __pathBuilder = new PathBuilder(
                path: "/eventsub/subscriptions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("type", type?.ToValueString()) 
                .AddOptionalParameter("user_id", userId) 
                .AddOptionalParameter("after", after) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetEventsubSubscriptionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                status: status,
                type: type,
                userId: userId,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetEventsubSubscriptionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetEventsubSubscriptionsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.GetEventSubSubscriptionsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}