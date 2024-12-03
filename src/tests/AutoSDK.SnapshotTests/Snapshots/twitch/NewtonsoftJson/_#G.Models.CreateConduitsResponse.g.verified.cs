﻿//HintName: G.Models.CreateConduitsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConduitsResponse
    {
        /// <summary>
        /// List of information about the client’s conduits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateConduitsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConduitsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of information about the client’s conduits.
        /// </param>
        public CreateConduitsResponse(
            global::System.Collections.Generic.IList<global::G.CreateConduitsResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConduitsResponse" /> class.
        /// </summary>
        public CreateConduitsResponse()
        {
        }
    }
}