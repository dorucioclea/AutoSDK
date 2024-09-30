﻿//HintName: G.IJobsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Monitor background jobs such as rebuilding indexes or updating corpus settings<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IJobsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}