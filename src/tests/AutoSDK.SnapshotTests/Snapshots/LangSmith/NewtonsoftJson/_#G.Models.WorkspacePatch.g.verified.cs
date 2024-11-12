﻿//HintName: G.Models.WorkspacePatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Patch model for the workspace.
    /// </summary>
    public sealed partial class WorkspacePatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacePatch" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        public WorkspacePatch(
            string displayName)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspacePatch" /> class.
        /// </summary>
        public WorkspacePatch()
        {
        }
    }
}