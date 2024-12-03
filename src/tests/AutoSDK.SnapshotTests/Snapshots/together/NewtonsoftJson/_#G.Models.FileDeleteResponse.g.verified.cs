﻿//HintName: G.Models.FileDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
        public FileDeleteResponse(
            bool? deleted,
            string? id)
        {
            this.Deleted = deleted;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDeleteResponse" /> class.
        /// </summary>
        public FileDeleteResponse()
        {
        }
    }
}