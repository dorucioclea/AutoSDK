﻿//HintName: JsonConverters.BetaBashTool20241022CacheControlDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaBashTool20241022CacheControlDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaBashTool20241022CacheControlDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.BetaBashTool20241022CacheControlDiscriminatorType Read(
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
                        return global::G.BetaBashTool20241022CacheControlDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BetaBashTool20241022CacheControlDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaBashTool20241022CacheControlDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BetaBashTool20241022CacheControlDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
