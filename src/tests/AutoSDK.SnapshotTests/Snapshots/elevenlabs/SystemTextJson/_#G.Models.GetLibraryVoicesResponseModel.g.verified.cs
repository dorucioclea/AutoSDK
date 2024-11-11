﻿//HintName: G.Models.GetLibraryVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLibraryVoicesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LibraryVoiceResponseModel> Voices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sort_id")]
        public string? LastSortId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLibraryVoicesResponseModel" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastSortId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetLibraryVoicesResponseModel(
            global::System.Collections.Generic.IList<global::G.LibraryVoiceResponseModel> voices,
            bool hasMore,
            string? lastSortId)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.HasMore = hasMore;
            this.LastSortId = lastSortId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLibraryVoicesResponseModel" /> class.
        /// </summary>
        public GetLibraryVoicesResponseModel()
        {
        }
    }
}