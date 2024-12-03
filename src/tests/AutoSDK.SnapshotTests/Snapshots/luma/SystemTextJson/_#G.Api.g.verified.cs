﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate videos using Dream Machine.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.lumalabs.ai/dream-machine/v1";

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
                    new global::G.JsonConverters.AspectRatioJsonConverter(),
                    new global::G.JsonConverters.AspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationRequestGenerationTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationReferenceTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationReferenceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageReferenceTypeJsonConverter(),
                    new global::G.JsonConverters.ImageReferenceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KeyframeDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.KeyframeDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter(),
                    new global::G.JsonConverters.ImageGenerationRequestGenerationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageModelJsonConverter(),
                    new global::G.JsonConverters.ImageModelNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationRequestDiscriminatorGenerationTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationRequestDiscriminatorGenerationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StateJsonConverter(),
                    new global::G.JsonConverters.StateNullableJsonConverter(),
                    new global::G.JsonConverters.RequestJsonConverter(),
                    new global::G.JsonConverters.KeyframeJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationsClient Generations => new GenerationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PingClient Ping => new PingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
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