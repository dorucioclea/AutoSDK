﻿//HintName: G.Models.ColorPaletteWithMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A color palette represented only via its members
    /// </summary>
    public sealed partial class ColorPaletteWithMembers
    {
        /// <summary>
        /// A list of ColorPaletteMembers that define the color palette.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ColorPaletteMember> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}