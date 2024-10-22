﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://www.mystic.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AcceleratorJsonConverter(),
                    new global::G.JsonConverters.AcceleratorNullableJsonConverter(),
                    new global::G.JsonConverters.AccountTierJsonConverter(),
                    new global::G.JsonConverters.AccountTierNullableJsonConverter(),
                    new global::G.JsonConverters.RunIOTypeJsonConverter(),
                    new global::G.JsonConverters.RunIOTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContainerRunErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ContainerRunErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStateJsonConverter(),
                    new global::G.JsonConverters.RunStateNullableJsonConverter(),
                    new global::G.JsonConverters.DurationUnitJsonConverter(),
                    new global::G.JsonConverters.DurationUnitNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineStateJsonConverter(),
                    new global::G.JsonConverters.PipelineStateNullableJsonConverter(),
                    new global::G.JsonConverters.OrderByJsonConverter(),
                    new global::G.JsonConverters.OrderByNullableJsonConverter(),
                    new global::G.JsonConverters.ScalingConfigTypeJsonConverter(),
                    new global::G.JsonConverters.ScalingConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.AllOfJsonConverterFactory1(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens => new TokensClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PointersClient Pointers => new PointersClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFamiliesClient PipelineFamilies => new PipelineFamiliesClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CloudClient Cloud => new CloudClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CredentialsClient Credentials => new CredentialsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GCPClient GCP => new GCPClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AWSClient AWS => new AWSClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AzureClient Azure => new AzureClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClusterClient Cluster => new ClusterClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources => new ResourcesClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScalingConfigurationsClient ScalingConfigurations => new ScalingConfigurationsClient(HttpClient, authorizations: Authorizations)
        {
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