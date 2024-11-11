﻿//HintName: G.Models.GetObjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.AIObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        public GetObjectResponse(
            global::G.AIObject? @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectResponse" /> class.
        /// </summary>
        public GetObjectResponse()
        {
        }
    }
}