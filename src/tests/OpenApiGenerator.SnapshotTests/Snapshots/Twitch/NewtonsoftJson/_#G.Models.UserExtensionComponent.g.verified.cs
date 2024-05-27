﻿//HintName: G.Models.UserExtensionComponent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtensionComponent
    {
        /// <summary>
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured a component extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The extension’s version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The extension’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The x-coordinate where the extension is placed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        /// The y-coordinate where the extension is placed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}