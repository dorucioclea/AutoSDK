﻿//HintName: G.Models.MigrationsUpdateImportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsUpdateImportRequest
    {
        /// <summary>
        /// The username to provide to the originating repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_username")]
        public string? VcsUsername { get; set; }

        /// <summary>
        /// The password to provide to the originating repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_password")]
        public string? VcsPassword { get; set; }

        /// <summary>
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </summary>
        /// <example>"git"</example>
        [global::Newtonsoft.Json.JsonProperty("vcs")]
        public global::G.MigrationsUpdateImportRequestVcs? Vcs { get; set; }

        /// <summary>
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </summary>
        /// <example>"project1"</example>
        [global::Newtonsoft.Json.JsonProperty("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsUpdateImportRequest" /> class.
        /// </summary>
        /// <param name="vcsUsername">
        /// The username to provide to the originating repository.
        /// </param>
        /// <param name="vcsPassword">
        /// The password to provide to the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </param>
        public MigrationsUpdateImportRequest(
            string? vcsUsername,
            string? vcsPassword,
            global::G.MigrationsUpdateImportRequestVcs? vcs,
            string? tfvcProject)
        {
            this.VcsUsername = vcsUsername;
            this.VcsPassword = vcsPassword;
            this.Vcs = vcs;
            this.TfvcProject = tfvcProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsUpdateImportRequest" /> class.
        /// </summary>
        public MigrationsUpdateImportRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MigrationsUpdateImportRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MigrationsUpdateImportRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.MigrationsUpdateImportRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MigrationsUpdateImportRequest?>(serializer.Deserialize<global::G.MigrationsUpdateImportRequest>(jsonReader));
        }

    }
}