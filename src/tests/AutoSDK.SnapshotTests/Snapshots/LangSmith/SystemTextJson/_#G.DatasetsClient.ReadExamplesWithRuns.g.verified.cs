﻿//HintName: G.DatasetsClient.ReadExamplesWithRuns.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadExamplesWithRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            global::G.QueryExampleSchemaWithRuns request);
        partial void PrepareReadExamplesWithRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::G.QueryExampleSchemaWithRuns request);
        partial void ProcessReadExamplesWithRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadExamplesWithRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>> ReadExamplesWithRunsAsync(
            global::System.Guid datasetId,
            global::G.QueryExampleSchemaWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReadExamplesWithRunsArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/datasets/{datasetId}/runs",
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
            PrepareReadExamplesWithRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadExamplesWithRunsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReadExamplesWithRunsResponseContent(
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
                    global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Read Examples With Runs<br/>
        /// Fetch examples for a dataset, and fetch the runs for each example if they are associated with the given session_ids.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionIds"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>> ReadExamplesWithRunsAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Guid? comparativeExperimentId = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters = default,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.QueryExampleSchemaWithRuns
            {
                SessionIds = sessionIds,
                ComparativeExperimentId = comparativeExperimentId,
                Filters = filters,
                Offset = offset,
                Limit = limit,
            };

            return await ReadExamplesWithRunsAsync(
                datasetId: datasetId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}