﻿//HintName: JsonConverters.CreateThreadAndRunRequestToolChoice.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateThreadAndRunRequestToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateThreadAndRunRequestToolChoice>
    {
        /// <inheritdoc />
        public override global::G.CreateThreadAndRunRequestToolChoice Read(
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
                        return global::G.CreateThreadAndRunRequestToolChoiceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateThreadAndRunRequestToolChoice)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateThreadAndRunRequestToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CreateThreadAndRunRequestToolChoiceExtensions.ToValueString(value));
        }
    }
}