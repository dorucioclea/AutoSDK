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
                client: HttpClient);
            PrepareV1WebhookEndpointAddArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/webhook/endpoint.add",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1WebhookEndpointAddRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1WebhookEndpointAddResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
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
            var __request = new global::G.V1WebhookEndpointAddRequest
            {
                Events = events,
                Url = url,
            };

            await V1WebhookEndpointAddAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}