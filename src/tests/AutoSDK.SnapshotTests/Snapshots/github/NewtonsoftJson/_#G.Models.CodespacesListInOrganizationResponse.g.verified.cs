﻿//HintName: G.Models.CodespacesListInOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesListInOrganizationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codespaces", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Codespace> Codespaces { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListInOrganizationResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="codespaces"></param>
        public CodespacesListInOrganizationResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.Codespace> codespaces)
        {
            this.TotalCount = totalCount;
            this.Codespaces = codespaces ?? throw new global::System.ArgumentNullException(nameof(codespaces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListInOrganizationResponse" /> class.
        /// </summary>
        public CodespacesListInOrganizationResponse()
        {
        }
    }
}