﻿//HintName: G.Models.AddProjectResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectResponseModel Project { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        /// <param name="project"></param>
        public AddProjectResponseModel(
            global::G.ProjectResponseModel project)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectResponseModel" /> class.
        /// </summary>
        public AddProjectResponseModel()
        {
        }
    }
}