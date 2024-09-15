﻿//HintName: G.IFilesClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IFilesClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}