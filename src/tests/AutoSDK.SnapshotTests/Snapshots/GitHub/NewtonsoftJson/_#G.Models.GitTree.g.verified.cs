﻿//HintName: G.Models.GitTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The hierarchy between files in a Git repository.
    /// </summary>
    public sealed partial class GitTree
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Truncated { get; set; } = default!;

        /// <summary>
        /// Objects specifying a tree structure<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("tree", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GitTreeTreeItem> Tree { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTree" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        /// <param name="truncated"></param>
        /// <param name="tree">
        /// Objects specifying a tree structure<br/>
        /// Example: []
        /// </param>
        public GitTree(
            string sha,
            string url,
            bool truncated,
            global::System.Collections.Generic.IList<global::G.GitTreeTreeItem> tree)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Truncated = truncated;
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTree" /> class.
        /// </summary>
        public GitTree()
        {
        }
    }
}