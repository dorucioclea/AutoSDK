﻿//HintName: JsonConverters.ActionsCreateOrUpdateOrgSecretRequestVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActionsCreateOrUpdateOrgSecretRequestVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ActionsCreateOrUpdateOrgSecretRequestVisibility>
    {
        /// <inheritdoc />
        public override global::G.ActionsCreateOrUpdateOrgSecretRequestVisibility Read(
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
                        return global::G.ActionsCreateOrUpdateOrgSecretRequestVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ActionsCreateOrUpdateOrgSecretRequestVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ActionsCreateOrUpdateOrgSecretRequestVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ActionsCreateOrUpdateOrgSecretRequestVisibilityExtensions.ToValueString(value));
        }
    }
}
