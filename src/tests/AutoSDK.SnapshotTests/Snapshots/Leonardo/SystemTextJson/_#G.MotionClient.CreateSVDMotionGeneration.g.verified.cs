﻿//HintName: G.MotionClient.CreateSVDMotionGeneration.g.cs

#nullable enable

namespace G
{
    public partial class MotionClient
    {
        partial void PrepareCreateSVDMotionGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateSVDMotionGenerationRequest request);
        partial void PrepareCreateSVDMotionGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateSVDMotionGenerationRequest request);
        partial void ProcessCreateSVDMotionGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSVDMotionGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create SVD Motion Generation<br/>
        /// This endpoint will generate a SVD motion generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateSVDMotionGenerationResponse> CreateSVDMotionGenerationAsync(
            global::G.CreateSVDMotionGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateSVDMotionGenerationArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/generations-motion-svd",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateSVDMotionGenerationRequest(
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
            ProcessCreateSVDMotionGenerationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateSVDMotionGenerationResponseContent(
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
                global::G.CreateSVDMotionGenerationResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create SVD Motion Generation<br/>
        /// This endpoint will generate a SVD motion generation.
        /// </summary>
        /// <param name="imageId">
        /// The ID of the image, supports generated images, variation images, and init images.
        /// </param>
        /// <param name="isPublic">
        /// Whether the generation is public or not
        /// </param>
        /// <param name="isInitImage">
        /// If it is an init image uploaded by the user. This image is uploaded from endpoint: Upload init image.
        /// </param>
        /// <param name="isVariation">
        /// If it is a variation image.
        /// </param>
        /// <param name="motionStrength">
        /// The motion strength.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateSVDMotionGenerationResponse> CreateSVDMotionGenerationAsync(
            string imageId,
            bool? isPublic = default,
            bool? isInitImage = default,
            bool? isVariation = default,
            int? motionStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateSVDMotionGenerationRequest
            {
                ImageId = imageId,
                IsPublic = isPublic,
                IsInitImage = isInitImage,
                IsVariation = isVariation,
                MotionStrength = motionStrength,
            };

            return await CreateSVDMotionGenerationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}