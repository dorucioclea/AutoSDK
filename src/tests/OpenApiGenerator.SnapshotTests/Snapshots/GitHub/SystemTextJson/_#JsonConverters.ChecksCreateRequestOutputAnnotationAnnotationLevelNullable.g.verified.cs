﻿//HintName: JsonConverters.ChecksCreateRequestOutputAnnotationAnnotationLevelNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChecksCreateRequestOutputAnnotationAnnotationLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChecksCreateRequestOutputAnnotationAnnotationLevel?>
    {
        /// <inheritdoc />
        public override global::G.ChecksCreateRequestOutputAnnotationAnnotationLevel? Read(
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
                        return global::G.ChecksCreateRequestOutputAnnotationAnnotationLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChecksCreateRequestOutputAnnotationAnnotationLevel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChecksCreateRequestOutputAnnotationAnnotationLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ChecksCreateRequestOutputAnnotationAnnotationLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
