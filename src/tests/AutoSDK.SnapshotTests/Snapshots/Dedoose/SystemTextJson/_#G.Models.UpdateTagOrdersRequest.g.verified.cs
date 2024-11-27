﻿//HintName: G.Models.UpdateTagOrdersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTagOrdersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Tag> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagOrdersRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateTagOrdersRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.Tag> tags)
        {
            this.ProjectId = projectId;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagOrdersRequest" /> class.
        /// </summary>
        public UpdateTagOrdersRequest()
        {
        }
    }
}