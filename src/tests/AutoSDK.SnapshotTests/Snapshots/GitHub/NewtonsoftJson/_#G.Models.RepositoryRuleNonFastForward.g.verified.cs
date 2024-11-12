﻿//HintName: G.Models.RepositoryRuleNonFastForward.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent users with push access from force pushing to refs.
    /// </summary>
    public sealed partial class RepositoryRuleNonFastForward
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleNonFastForwardType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleNonFastForward" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RepositoryRuleNonFastForward(
            global::G.RepositoryRuleNonFastForwardType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleNonFastForward" /> class.
        /// </summary>
        public RepositoryRuleNonFastForward()
        {
        }
    }
}