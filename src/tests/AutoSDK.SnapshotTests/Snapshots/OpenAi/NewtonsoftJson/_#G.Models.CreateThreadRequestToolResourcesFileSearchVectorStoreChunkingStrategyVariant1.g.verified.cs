﻿//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1
    {
        /// <summary>
        /// Always `auto`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1(
            global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1()
        {
        }
    }
}