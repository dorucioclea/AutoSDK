﻿//HintName: G.TagClient.TagUpdateTag.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagUpdateTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? projectId,
            ref global::System.Guid? id,
            ref global::System.Guid? projectIDL,
            ref string? title,
            ref string? description,
            ref bool? isWeighted,
            ref double? weightMin,
            ref double? weightMax,
            ref double? weightDefault,
            ref int? sortOrder,
            ref int? color,
            ref bool? allowDecimalWeight);
        partial void PrepareTagUpdateTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            string? title,
            string? description,
            bool? isWeighted,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            int? sortOrder,
            int? color,
            bool? allowDecimalWeight);
        partial void ProcessTagUpdateTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagUpdateTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTag.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="sortOrder"></param>
        /// <param name="color"></param>
        /// <param name="allowDecimalWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Tag> TagUpdateTagAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? projectId = default,
            global::System.Guid? id = default,
            global::System.Guid? projectIDL = default,
            string? title = default,
            string? description = default,
            bool? isWeighted = default,
            double? weightMin = default,
            double? weightMax = default,
            double? weightDefault = default,
            int? sortOrder = default,
            int? color = default,
            bool? allowDecimalWeight = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTagUpdateTagArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                title: ref title,
                description: ref description,
                isWeighted: ref isWeighted,
                weightMin: ref weightMin,
                weightMax: ref weightMax,
                weightDefault: ref weightDefault,
                sortOrder: ref sortOrder,
                color: ref color,
                allowDecimalWeight: ref allowDecimalWeight);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/updatetag",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("Description", description) 
                .AddOptionalParameter("IsWeighted", isWeighted?.ToString()) 
                .AddOptionalParameter("WeightMin", weightMin?.ToString()) 
                .AddOptionalParameter("WeightMax", weightMax?.ToString()) 
                .AddOptionalParameter("WeightDefault", weightDefault?.ToString()) 
                .AddOptionalParameter("SortOrder", sortOrder?.ToString()) 
                .AddOptionalParameter("Color", color?.ToString()) 
                .AddOptionalParameter("AllowDecimalWeight", allowDecimalWeight?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTagUpdateTagRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                title: title,
                description: description,
                isWeighted: isWeighted,
                weightMin: weightMin,
                weightMax: weightMax,
                weightDefault: weightDefault,
                sortOrder: sortOrder,
                color: color,
                allowDecimalWeight: allowDecimalWeight);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTagUpdateTagResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTagUpdateTagResponseContent(
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
                global::G.Tag.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}