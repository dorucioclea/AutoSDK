﻿//HintName: G.Api.EndPoints.CreateRun.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> CreateRunAsync(
            CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/threads/{thread_id}/runs");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RunObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="additionalInstructions"></param>
        /// <param name="additionalMessages"></param>
        /// <param name="tools"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stream"></param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> CreateRunAsync(
            string assistantId,
            object? model,
            string? instructions,
            string? additionalInstructions,
            global::System.Collections.Generic.IList<CreateMessageRequest>? additionalMessages,
            global::System.Collections.Generic.IList<object?>? tools,
            CreateRunRequestMetadata? metadata,
            double? temperature,
            double? topP,
            bool? stream,
            int? maxPromptTokens,
            int? maxCompletionTokens,
            TruncationObject? truncationStrategy,
            AssistantsApiToolChoiceOption? toolChoice,
            AssistantsApiResponseFormatOption? responseFormat,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateRunRequest
            {
                AssistantId = assistantId,
                Model = model,
                Instructions = instructions,
                AdditionalInstructions = additionalInstructions,
                AdditionalMessages = additionalMessages,
                Tools = tools,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                Stream = stream,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
            };

            return await CreateRunAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}