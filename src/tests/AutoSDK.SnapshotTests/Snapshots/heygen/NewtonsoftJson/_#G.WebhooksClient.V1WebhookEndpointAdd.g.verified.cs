﻿//HintName: G.WebhooksClient.V1WebhookEndpointAdd.g.cs

#nullable enable

namespace G
{
    public partial class WebhooksClient
    {
        partial void PrepareV1WebhookEndpointAddArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.V1WebhookEndpointAddRequest request);
        partial void PrepareV1WebhookEndpointAddRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.V1WebhookEndpointAddRequest request);
        partial void ProcessV1WebhookEndpointAddResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(
            global::G.V1WebhookEndpointAddRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1WebhookEndpointAddArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/webhook/endpoint.add",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1WebhookEndpointAddRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1WebhookEndpointAddResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="events">
        /// Example: []
        /// </param>
        /// <param name="url">
        /// Example: &lt;url&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(
            global::System.Collections.Generic.IList<object>? events = default,
            string? url = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.V1WebhookEndpointAddRequest
            {
                Events = events,
                Url = url,
            };

            await V1WebhookEndpointAddAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}