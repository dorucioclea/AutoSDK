﻿//HintName: G.Models.FileCommitCommitTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitCommitTree
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitTree" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sha"></param>
        public FileCommitCommitTree(
            string? url,
            string? sha)
        {
            this.Url = url;
            this.Sha = sha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitTree" /> class.
        /// </summary>
        public FileCommitCommitTree()
        {
        }
    }
}