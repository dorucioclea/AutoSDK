﻿//HintName: JsonConverters.ReviewCustomGatesStateRequiredState.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReviewCustomGatesStateRequiredStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReviewCustomGatesStateRequiredState>
    {
        /// <inheritdoc />
        public override global::G.ReviewCustomGatesStateRequiredState Read(
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
                        return global::G.ReviewCustomGatesStateRequiredStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReviewCustomGatesStateRequiredState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReviewCustomGatesStateRequiredState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ReviewCustomGatesStateRequiredStateExtensions.ToValueString(value));
        }
    }
}
