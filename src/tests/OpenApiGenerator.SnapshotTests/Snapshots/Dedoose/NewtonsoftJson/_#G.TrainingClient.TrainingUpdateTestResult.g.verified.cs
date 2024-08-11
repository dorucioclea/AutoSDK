﻿//HintName: G.TrainingClient.TrainingUpdateTestResult.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingUpdateTestResultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? traineeUserId,
            ref string? testId,
            ref string? resultId,
            ref double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps,
            ref bool completed);
        partial void PrepareTrainingUpdateTestResultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? traineeUserId,
            string? testId,
            string? resultId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps,
            bool completed);
        partial void ProcessTrainingUpdateTestResultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingUpdateTestResultResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTestResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="resultId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingTestResult> TrainingUpdateTestResultAsync(
            string? token,
            string? projectId,
            string? traineeUserId,
            string? testId,
            string? resultId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps,
            bool completed,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingUpdateTestResultArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                traineeUserId: ref traineeUserId,
                testId: ref testId,
                resultId: ref resultId,
                overallRating: ref overallRating,
                traineeTagApps: traineeTagApps,
                completed: ref completed);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/updatetestresult?projectId={projectId}&traineeUserId={traineeUserId}&testId={testId}&resultId={resultId}&overallRating={overallRating}&{string.Join("&", traineeTagApps?.Select(static x => $"traineeTagApps={x}") ?? global::System.Array.Empty<string>())}&completed={completed}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingUpdateTestResultRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                traineeUserId: traineeUserId,
                testId: testId,
                resultId: resultId,
                overallRating: overallRating,
                traineeTagApps: traineeTagApps,
                completed: completed);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingUpdateTestResultResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingUpdateTestResultResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TrainingTestResult?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}