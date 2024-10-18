﻿//HintName: G.OrgsClient.OrgsCreateOrUpdateCustomProperties.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request);
        partial void PrepareOrgsCreateOrUpdateCustomPropertiesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request);
        partial void ProcessOrgsCreateOrUpdateCustomPropertiesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateOrUpdateCustomPropertiesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomProperty>> OrgsCreateOrUpdateCustomPropertiesAsync(
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsCreateOrUpdateCustomPropertiesArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/schema",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsCreateOrUpdateCustomPropertiesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsCreateOrUpdateCustomPropertiesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsCreateOrUpdateCustomPropertiesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CustomProperty>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="properties">
        /// The array of custom properties to create or update.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomProperty>> OrgsCreateOrUpdateCustomPropertiesAsync(
            string org,
            global::System.Collections.Generic.IList<global::G.CustomProperty> properties,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsCreateOrUpdateCustomPropertiesRequest
            {
                Properties = properties,
            };

            return await OrgsCreateOrUpdateCustomPropertiesAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}