﻿//HintName: G.Models.ExtensionIconUrls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.
    /// </summary>
    public sealed partial class ExtensionIconUrls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("100x100")]
        public string? _100x100 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("24x24")]
        public string? _24x24 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("300x200")]
        public string? _300x200 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}