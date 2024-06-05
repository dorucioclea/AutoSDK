﻿//HintName: JsonConverters.MessageObjectIncompleteDetailsReasonNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageObjectIncompleteDetailsReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageObjectIncompleteDetailsReason?>
    {
        /// <inheritdoc />
        public override global::G.MessageObjectIncompleteDetailsReason? Read(
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
                        return global::G.MessageObjectIncompleteDetailsReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MessageObjectIncompleteDetailsReason)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageObjectIncompleteDetailsReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MessageObjectIncompleteDetailsReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
