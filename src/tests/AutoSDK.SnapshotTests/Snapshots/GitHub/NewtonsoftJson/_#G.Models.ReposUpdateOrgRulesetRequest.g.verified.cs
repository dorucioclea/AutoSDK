﻿//HintName: G.Models.ReposUpdateOrgRulesetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateOrgRulesetRequest
    {
        /// <summary>
        /// The name of the ruleset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The target of the ruleset<br/>
        /// **Note**: The `push` target is in beta and is subject to change.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.ReposUpdateOrgRulesetRequestTarget? Target { get; set; }

        /// <summary>
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement")]
        public global::G.RepositoryRuleEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The actors that can bypass the rules in this ruleset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_actors")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? BypassActors { get; set; }

        /// <summary>
        /// Conditions for an organization ruleset. The conditions object should contain both `repository_name` and `ref_name` properties or both `repository_id` and `ref_name` properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions")]
        public global::G.OrgRulesetConditions? Conditions { get; set; }

        /// <summary>
        /// An array of rules within the ruleset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposUpdateOrgRulesetRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposUpdateOrgRulesetRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}