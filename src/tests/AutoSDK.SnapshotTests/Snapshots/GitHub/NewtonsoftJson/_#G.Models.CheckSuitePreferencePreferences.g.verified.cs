﻿//HintName: G.Models.CheckSuitePreferencePreferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckSuitePreferencePreferences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_trigger_checks")]
        public global::System.Collections.Generic.IList<global::G.CheckSuitePreferencePreferencesAutoTriggerCheck>? AutoTriggerChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferences" /> class.
        /// </summary>
        /// <param name="autoTriggerChecks"></param>
        public CheckSuitePreferencePreferences(
            global::System.Collections.Generic.IList<global::G.CheckSuitePreferencePreferencesAutoTriggerCheck>? autoTriggerChecks)
        {
            this.AutoTriggerChecks = autoTriggerChecks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferences" /> class.
        /// </summary>
        public CheckSuitePreferencePreferences()
        {
        }
    }
}