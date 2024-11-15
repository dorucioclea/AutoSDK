﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A web service for running Replicate models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.replicate.com/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::G.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::G.JsonConverters.ModelsCreateRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.AccountGetResponseTypeJsonConverter(),
                    new global::G.JsonConverters.AccountGetResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::G.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}