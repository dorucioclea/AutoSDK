﻿//HintName: G.Models.PendingDeploymentReviewer.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingDeploymentReviewer
    {
        /// <summary>
        /// The type of reviewer.<br/>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeploymentReviewerTypeJsonConverter))]
        public global::G.DeploymentReviewerType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::G.SimpleUser, global::G.Team>? Reviewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentReviewer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reviewer.<br/>
        /// Example: User
        /// </param>
        /// <param name="reviewer"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PendingDeploymentReviewer(
            global::G.DeploymentReviewerType? type,
            global::G.AnyOf<global::G.SimpleUser, global::G.Team>? reviewer)
        {
            this.Type = type;
            this.Reviewer = reviewer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentReviewer" /> class.
        /// </summary>
        public PendingDeploymentReviewer()
        {
        }
    }
}