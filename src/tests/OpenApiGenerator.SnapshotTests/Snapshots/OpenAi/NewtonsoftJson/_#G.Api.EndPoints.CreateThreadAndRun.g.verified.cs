﻿//HintName: G.Api.EndPoints.CreateThreadAndRun.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> CreateThreadAndRunAsync(
            CreateThreadAndRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/threads/runs");
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
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="thread"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
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
        public async global::System.Threading.Tasks.Task<RunObject> CreateThreadAndRunAsync(
            string assistantId,
            CreateThreadRequest? thread,
            object? model,
            string? instructions,
            global::System.Collections.Generic.IList<object?>? tools,
            CreateThreadAndRunRequestToolResources? toolResources,
            CreateThreadAndRunRequestMetadata? metadata,
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
            var request = new CreateThreadAndRunRequest
            {
                AssistantId = assistantId,
                Thread = thread,
                Model = model,
                Instructions = instructions,
                Tools = tools,
                ToolResources = toolResources,
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

            return await CreateThreadAndRunAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}