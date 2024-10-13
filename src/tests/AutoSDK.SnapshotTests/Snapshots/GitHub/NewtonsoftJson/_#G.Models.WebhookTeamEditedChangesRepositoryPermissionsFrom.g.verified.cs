﻿//HintName: G.Models.WebhookTeamEditedChangesRepositoryPermissionsFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTeamEditedChangesRepositoryPermissionsFrom
    {
        /// <summary>
        /// The previous version of the team member's `admin` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// The previous version of the team member's `pull` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull")]
        public bool? Pull { get; set; }

        /// <summary>
        /// The previous version of the team member's `push` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push")]
        public bool? Push { get; set; }

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
        public static global::G.WebhookTeamEditedChangesRepositoryPermissionsFrom? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookTeamEditedChangesRepositoryPermissionsFrom>(
                json,
                jsonSerializerOptions);
        }

    }
}