﻿//HintName: JsonConverters.CodespacesSetCodespacesAccessRequestVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodespacesSetCodespacesAccessRequestVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodespacesSetCodespacesAccessRequestVisibility>
    {
        /// <inheritdoc />
        public override global::G.CodespacesSetCodespacesAccessRequestVisibility Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.CodespacesSetCodespacesAccessRequestVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodespacesSetCodespacesAccessRequestVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodespacesSetCodespacesAccessRequestVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CodespacesSetCodespacesAccessRequestVisibilityExtensions.ToValueString(value));
        }
    }
}
