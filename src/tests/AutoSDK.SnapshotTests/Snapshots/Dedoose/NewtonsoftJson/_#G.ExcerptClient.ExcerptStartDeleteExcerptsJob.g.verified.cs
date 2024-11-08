﻿//HintName: G.ExcerptClient.ExcerptStartDeleteExcerptsJob.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptStartDeleteExcerptsJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? currentProjectId,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds);
        partial void PrepareExcerptStartDeleteExcerptsJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? currentProjectId,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds);
        partial void ProcessExcerptStartDeleteExcerptsJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptStartDeleteExcerptsJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartDeleteExcerptsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExcerptStartDeleteExcerptsJobAsync(
            string? token = default,
            global::System.Guid? currentProjectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareExcerptStartDeleteExcerptsJobArguments(
                httpClient: HttpClient,
                token: ref token,
                currentProjectId: ref currentProjectId,
                excerptIds: excerptIds);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/excerpt/startdeleteexcerptsjob",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("currentProjectId", currentProjectId?.ToString()) 
                .AddOptionalParameter("excerptIds", excerptIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
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
            PrepareExcerptStartDeleteExcerptsJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                currentProjectId: currentProjectId,
                excerptIds: excerptIds);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExcerptStartDeleteExcerptsJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessExcerptStartDeleteExcerptsJobResponseContent(
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

                    return __content;
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using var __streamReader = new global::System.IO.StreamReader(__responseStream);
            using var __jsonReader = new global::Newtonsoft.Json.JsonTextReader(__streamReader);
            var __serializer = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions);
            var __responseValue = __serializer.Deserialize<string?>(__jsonReader);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}