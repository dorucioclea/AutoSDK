﻿//HintName: G.Models.ReposSetAppAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposSetAppAccessRestrictionsRequest
    {
        /// <summary>
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Apps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetAppAccessRestrictionsRequest" /> class.
        /// </summary>
        /// <param name="apps">
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </param>
        public ReposSetAppAccessRestrictionsRequest(
            global::System.Collections.Generic.IList<string> apps)
        {
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetAppAccessRestrictionsRequest" /> class.
        /// </summary>
        public ReposSetAppAccessRestrictionsRequest()
        {
        }
    }
}