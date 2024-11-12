﻿//HintName: G.Models.ReposUpdateStatusCheckProtectionRequestCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateStatusCheckProtectionRequestCheck
    {
        /// <summary>
        /// The name of the required check
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateStatusCheckProtectionRequestCheck" /> class.
        /// </summary>
        /// <param name="context">
        /// The name of the required check
        /// </param>
        /// <param name="appId">
        /// The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.
        /// </param>
        public ReposUpdateStatusCheckProtectionRequestCheck(
            string context,
            int? appId)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.AppId = appId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateStatusCheckProtectionRequestCheck" /> class.
        /// </summary>
        public ReposUpdateStatusCheckProtectionRequestCheck()
        {
        }
    }
}