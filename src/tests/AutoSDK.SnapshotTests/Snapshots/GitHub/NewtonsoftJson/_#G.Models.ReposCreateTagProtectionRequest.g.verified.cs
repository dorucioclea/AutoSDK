﻿//HintName: G.Models.ReposCreateTagProtectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateTagProtectionRequest
    {
        /// <summary>
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateTagProtectionRequest" /> class.
        /// </summary>
        /// <param name="pattern">
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </param>
        public ReposCreateTagProtectionRequest(
            string pattern)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateTagProtectionRequest" /> class.
        /// </summary>
        public ReposCreateTagProtectionRequest()
        {
        }
    }
}