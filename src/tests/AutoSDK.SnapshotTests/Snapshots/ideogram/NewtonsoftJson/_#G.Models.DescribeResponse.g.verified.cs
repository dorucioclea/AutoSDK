﻿//HintName: G.Models.DescribeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response for a describe request encapsulates a list of descriptions
    /// </summary>
    public sealed partial class DescribeResponse
    {
        /// <summary>
        /// A collection of descriptions for given content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptions")]
        public global::System.Collections.Generic.IList<global::G.Description>? Descriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}