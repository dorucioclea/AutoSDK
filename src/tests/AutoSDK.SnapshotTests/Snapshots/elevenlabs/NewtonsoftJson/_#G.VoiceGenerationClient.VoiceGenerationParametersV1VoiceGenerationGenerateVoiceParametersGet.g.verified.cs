﻿//HintName: G.VoiceGenerationClient.VoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGet.g.cs

#nullable enable

namespace G
{
    public partial class VoiceGenerationClient
    {
        partial void PrepareVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Voice Generation Parameters<br/>
        /// Get possible parameters for the /v1/voice-generation/generate-voice endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VoiceGenerationParameterResponseModel> VoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetArguments(
                httpClient: _httpClient);

            var __pathBuilder = new PathBuilder(
                path: "/v1/voice-generation/generate-voice/parameters",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessVoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetResponseContent(
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
                global::G.VoiceGenerationParameterResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}