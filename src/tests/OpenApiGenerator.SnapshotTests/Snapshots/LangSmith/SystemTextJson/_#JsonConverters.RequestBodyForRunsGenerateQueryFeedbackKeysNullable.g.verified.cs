﻿//HintName: JsonConverters.RequestBodyForRunsGenerateQueryFeedbackKeysNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestBodyForRunsGenerateQueryFeedbackKeysNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RequestBodyForRunsGenerateQueryFeedbackKeys?>
    {
        /// <inheritdoc />
        public override global::G.RequestBodyForRunsGenerateQueryFeedbackKeys? Read(
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
                        return global::G.RequestBodyForRunsGenerateQueryFeedbackKeysExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RequestBodyForRunsGenerateQueryFeedbackKeys)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RequestBodyForRunsGenerateQueryFeedbackKeys? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RequestBodyForRunsGenerateQueryFeedbackKeysExtensions.ToValueString(value.Value));
            }
        }
    }
}
