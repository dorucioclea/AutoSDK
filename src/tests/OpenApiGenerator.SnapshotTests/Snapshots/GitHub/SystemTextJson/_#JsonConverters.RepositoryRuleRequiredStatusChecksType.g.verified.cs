﻿//HintName: JsonConverters.RepositoryRuleRequiredStatusChecksType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryRuleRequiredStatusChecksTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryRuleRequiredStatusChecksType>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRuleRequiredStatusChecksType Read(
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
                        return global::G.RepositoryRuleRequiredStatusChecksTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryRuleRequiredStatusChecksType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRuleRequiredStatusChecksType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.RepositoryRuleRequiredStatusChecksTypeExtensions.ToValueString(value));
        }
    }
}
