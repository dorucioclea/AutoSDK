﻿//HintName: JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageDeltaContentTextAnnotationsFilePathObjectType?>
    {
        /// <inheritdoc />
        public override global::G.MessageDeltaContentTextAnnotationsFilePathObjectType? Read(
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
                        return global::G.MessageDeltaContentTextAnnotationsFilePathObjectTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MessageDeltaContentTextAnnotationsFilePathObjectType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageDeltaContentTextAnnotationsFilePathObjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MessageDeltaContentTextAnnotationsFilePathObjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}