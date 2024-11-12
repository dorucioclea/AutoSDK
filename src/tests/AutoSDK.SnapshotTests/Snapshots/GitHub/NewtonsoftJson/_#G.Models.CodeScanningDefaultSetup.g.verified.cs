﻿//HintName: G.Models.CodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetup
    {
        /// <summary>
        /// Code scanning default setup has been configured or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.CodeScanningDefaultSetupState? State { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupLanguage>? Languages { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_suite")]
        public global::G.CodeScanningDefaultSetupQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// Timestamp of latest configuration update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The frequency of the periodic analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedule")]
        public global::G.CodeScanningDefaultSetupSchedule? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        /// <param name="state">
        /// Code scanning default setup has been configured or not.
        /// </param>
        /// <param name="languages">
        /// Languages to be analyzed.
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of latest configuration update.
        /// </param>
        /// <param name="schedule">
        /// The frequency of the periodic analysis.
        /// </param>
        public CodeScanningDefaultSetup(
            global::G.CodeScanningDefaultSetupState? state,
            global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupLanguage>? languages,
            global::G.CodeScanningDefaultSetupQuerySuite? querySuite,
            global::System.DateTime? updatedAt,
            global::G.CodeScanningDefaultSetupSchedule? schedule)
        {
            this.State = state;
            this.Languages = languages;
            this.QuerySuite = querySuite;
            this.UpdatedAt = updatedAt;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetup" /> class.
        /// </summary>
        public CodeScanningDefaultSetup()
        {
        }
    }
}