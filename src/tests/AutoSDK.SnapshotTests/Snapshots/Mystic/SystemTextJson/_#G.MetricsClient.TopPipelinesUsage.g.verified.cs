﻿//HintName: G.MetricsClient.TopPipelinesUsage.g.cs

#nullable enable

namespace G
{
    public partial class MetricsClient
    {
        partial void PrepareTopPipelinesUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? numPipelines,
            ref string? clusterId,
            ref global::System.DateTime start,
            ref global::System.DateTime end,
            ref global::G.DurationUnit intervalUnit,
            ref int intervalValue);
        partial void PrepareTopPipelinesUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? numPipelines,
            string? clusterId,
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue);
        partial void ProcessTopPipelinesUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTopPipelinesUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Top Pipelines Usage<br/>
        /// Retrieve usage metrics for top 'num_pipelines' (in terms of number of<br/>
        /// runs) for the provided time period.
        /// </summary>
        /// <param name="numPipelines">
        /// Default Value: 20
        /// </param>
        /// <param name="clusterId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="intervalUnit">
        /// An enumeration.
        /// </param>
        /// <param name="intervalValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TopPipelinesUsageAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue,
            int? numPipelines = default,
            string? clusterId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTopPipelinesUsageArguments(
                httpClient: HttpClient,
                numPipelines: ref numPipelines,
                clusterId: ref clusterId,
                start: ref start,
                end: ref end,
                intervalUnit: ref intervalUnit,
                intervalValue: ref intervalValue);

            var __pathBuilder = new PathBuilder(
                path: "/v4/metrics/top-pipelines-usage",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("num_pipelines", numPipelines?.ToString()) 
                .AddOptionalParameter("cluster_id", clusterId) 
                .AddRequiredParameter("start", start.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("end", end.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("interval_unit", intervalUnit.ToValueString()) 
                .AddRequiredParameter("interval_value", intervalValue.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTopPipelinesUsageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                numPipelines: numPipelines,
                clusterId: clusterId,
                start: start,
                end: end,
                intervalUnit: intervalUnit,
                intervalValue: intervalValue);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTopPipelinesUsageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessTopPipelinesUsageResponseContent(
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
    }
}