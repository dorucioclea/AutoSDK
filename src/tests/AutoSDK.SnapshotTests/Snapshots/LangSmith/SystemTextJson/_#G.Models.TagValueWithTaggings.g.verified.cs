﻿//HintName: G.Models.TagValueWithTaggings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagValueWithTaggings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TagKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taggings")]
        public global::System.Collections.Generic.IList<global::G.Tagging>? Taggings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueWithTaggings" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="tagKeyId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="taggings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TagValueWithTaggings(
            string value,
            global::System.Guid id,
            global::System.Guid tagKeyId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::System.Collections.Generic.IList<global::G.Tagging>? taggings)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Id = id;
            this.TagKeyId = tagKeyId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.Taggings = taggings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueWithTaggings" /> class.
        /// </summary>
        public TagValueWithTaggings()
        {
        }
    }
}