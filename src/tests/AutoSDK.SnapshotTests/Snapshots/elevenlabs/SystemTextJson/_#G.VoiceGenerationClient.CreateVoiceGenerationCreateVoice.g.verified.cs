﻿//HintName: G.VoiceGenerationClient.CreateVoiceGenerationCreateVoice.g.cs

#nullable enable

namespace G
{
    public partial class VoiceGenerationClient
    {
        partial void PrepareCreateVoiceGenerationCreateVoiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost request);
        partial void PrepareCreateVoiceGenerationCreateVoiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost request);
        partial void ProcessCreateVoiceGenerationCreateVoiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoiceGenerationCreateVoiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create A Previously Generated Voice<br/>
        /// Create a previously generated voice. This endpoint should be called after you fetched a generated_voice_id using /v1/voice-generation/generate-voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VoiceResponseModel> CreateVoiceGenerationCreateVoiceAsync(
            global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVoiceGenerationCreateVoiceArguments(
                httpClient: HttpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/voice-generation/create-voice",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
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
            PrepareCreateVoiceGenerationCreateVoiceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVoiceGenerationCreateVoiceResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateVoiceGenerationCreateVoiceResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.VoiceResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create A Previously Generated Voice<br/>
        /// Create a previously generated voice. This endpoint should be called after you fetched a generated_voice_id using /v1/voice-generation/generate-voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="voiceName">
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VoiceResponseModel> CreateVoiceGenerationCreateVoiceAsync(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyCreateAPreviouslyGeneratedVoiceV1VoiceGenerationCreateVoicePost
            {
                VoiceName = voiceName,
                VoiceDescription = voiceDescription,
                GeneratedVoiceId = generatedVoiceId,
                PlayedNotSelectedVoiceIds = playedNotSelectedVoiceIds,
                Labels = labels,
            };

            return await CreateVoiceGenerationCreateVoiceAsync(
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}