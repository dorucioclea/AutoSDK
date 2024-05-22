﻿//HintName: G.Api.EndPoints.AuthorizeUsingBearer.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearerAsync(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: "Bearer",
                parameter: apiKey);
        }
    }
}