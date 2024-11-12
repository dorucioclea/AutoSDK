﻿//HintName: G.Models.CodespacesCodespaceMachinesForAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCodespaceMachinesForAuthenticatedUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machines", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodespaceMachine> Machines { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCodespaceMachinesForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="machines"></param>
        public CodespacesCodespaceMachinesForAuthenticatedUserResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CodespaceMachine> machines)
        {
            this.TotalCount = totalCount;
            this.Machines = machines ?? throw new global::System.ArgumentNullException(nameof(machines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCodespaceMachinesForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesCodespaceMachinesForAuthenticatedUserResponse()
        {
        }
    }
}