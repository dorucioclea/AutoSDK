﻿//HintName: G.Models.ReposDeleteFileRequestCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// object containing information about the committer.
    /// </summary>
    public sealed partial class ReposDeleteFileRequestCommitter
    {
        /// <summary>
        /// The name of the author (or committer) of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The email of the author (or committer) of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequestCommitter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the author (or committer) of the commit
        /// </param>
        /// <param name="email">
        /// The email of the author (or committer) of the commit
        /// </param>
        public ReposDeleteFileRequestCommitter(
            string? name,
            string? email)
        {
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequestCommitter" /> class.
        /// </summary>
        public ReposDeleteFileRequestCommitter()
        {
        }
    }
}