﻿//HintName: G.Models.GetProjectDescriptorLinksRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDescriptorLinksRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDescriptorLinksRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        public GetProjectDescriptorLinksRequest(
            global::System.Guid projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDescriptorLinksRequest" /> class.
        /// </summary>
        public GetProjectDescriptorLinksRequest()
        {
        }
    }
}