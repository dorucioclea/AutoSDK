﻿//HintName: G.Models.GetApiTermsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiTermsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_terms", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiTerms ApiTerms { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        /// <param name="apiTerms"></param>
        public GetApiTermsResponse(
            global::G.ApiTerms apiTerms)
        {
            this.ApiTerms = apiTerms ?? throw new global::System.ArgumentNullException(nameof(apiTerms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        public GetApiTermsResponse()
        {
        }
    }
}