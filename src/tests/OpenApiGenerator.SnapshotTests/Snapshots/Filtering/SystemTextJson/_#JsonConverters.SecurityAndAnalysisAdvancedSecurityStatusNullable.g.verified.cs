﻿//HintName: JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecurityAndAnalysisAdvancedSecurityStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SecurityAndAnalysisAdvancedSecurityStatus?>
    {
        /// <inheritdoc />
        public override global::G.SecurityAndAnalysisAdvancedSecurityStatus? Read(
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
                        return global::G.SecurityAndAnalysisAdvancedSecurityStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SecurityAndAnalysisAdvancedSecurityStatus)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SecurityAndAnalysisAdvancedSecurityStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SecurityAndAnalysisAdvancedSecurityStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
