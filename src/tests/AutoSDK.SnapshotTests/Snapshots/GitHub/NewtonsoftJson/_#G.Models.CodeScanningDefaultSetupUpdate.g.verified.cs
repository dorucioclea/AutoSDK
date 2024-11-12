﻿//HintName: G.Models.CodeScanningDefaultSetupUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdate
    {
        /// <summary>
        /// The desired state of code scanning default setup.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.CodeScanningDefaultSetupUpdateState? State { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_suite")]
        public global::G.CodeScanningDefaultSetupUpdateQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// CodeQL languages to be analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupUpdateLanguage>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        /// <param name="state">
        /// The desired state of code scanning default setup.
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="languages">
        /// CodeQL languages to be analyzed.
        /// </param>
        public CodeScanningDefaultSetupUpdate(
            global::G.CodeScanningDefaultSetupUpdateState? state,
            global::G.CodeScanningDefaultSetupUpdateQuerySuite? querySuite,
            global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupUpdateLanguage>? languages)
        {
            this.State = state;
            this.QuerySuite = querySuite;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        public CodeScanningDefaultSetupUpdate()
        {
        }
    }
}