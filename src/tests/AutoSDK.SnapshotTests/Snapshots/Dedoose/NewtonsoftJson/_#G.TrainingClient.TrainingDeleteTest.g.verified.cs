﻿//HintName: G.TrainingClient.TrainingDeleteTest.g.cs

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingDeleteTestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? id,
            ref int? testType,
            ref string? title,
            ref string? description,
            ref global::System.DateTime? createdOn,
            ref global::System.Guid? projectId,
            ref int? excerptCount,
            ref int? tagCount,
            ref global::System.Guid? creator);
        partial void PrepareTrainingDeleteTestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? id,
            int? testType,
            string? title,
            string? description,
            global::System.DateTime? createdOn,
            global::System.Guid? projectId,
            int? excerptCount,
            int? tagCount,
            global::System.Guid? creator);
        partial void ProcessTrainingDeleteTestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingDeleteTestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="testType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="projectId"></param>
        /// <param name="excerptCount"></param>
        /// <param name="tagCount"></param>
        /// <param name="creator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingTest> TrainingDeleteTestAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? id = default,
            int? testType = default,
            string? title = default,
            string? description = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? projectId = default,
            int? excerptCount = default,
            int? tagCount = default,
            global::System.Guid? creator = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTrainingDeleteTestArguments(
                httpClient: HttpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                testType: ref testType,
                title: ref title,
                description: ref description,
                createdOn: ref createdOn,
                projectId: ref projectId,
                excerptCount: ref excerptCount,
                tagCount: ref tagCount,
                creator: ref creator);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/training/deletetest",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("TestType", testType?.ToString()) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("Description", description) 
                .AddOptionalParameter("CreatedOn", createdOn?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("ExcerptCount", excerptCount?.ToString()) 
                .AddOptionalParameter("TagCount", tagCount?.ToString()) 
                .AddOptionalParameter("Creator", creator?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTrainingDeleteTestRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                testType: testType,
                title: title,
                description: description,
                createdOn: createdOn,
                projectId: projectId,
                excerptCount: excerptCount,
                tagCount: tagCount,
                creator: creator);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTrainingDeleteTestResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTrainingDeleteTestResponseContent(
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
                    global::G.TrainingTest.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.TrainingTest.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}