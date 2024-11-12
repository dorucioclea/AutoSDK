﻿//HintName: G.Models.CreateRepositoryTagResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateRepositoryTagResponse contains the created tag.
    /// </summary>
    public sealed partial class CreateRepositoryTagResponse
    {
        /// <summary>
        /// The created tag.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.RepositoryTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepositoryTagResponse" /> class.
        /// </summary>
        /// <param name="tag">
        /// The created tag.
        /// </param>
        public CreateRepositoryTagResponse(
            global::G.RepositoryTag? tag)
        {
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepositoryTagResponse" /> class.
        /// </summary>
        public CreateRepositoryTagResponse()
        {
        }
    }
}