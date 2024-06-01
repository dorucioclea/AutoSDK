﻿//HintName: JsonConverters.RepositoryAdvisoryIdentifiersType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryAdvisoryIdentifiersTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryAdvisoryIdentifiersType>
    {
        /// <inheritdoc />
        public override global::G.RepositoryAdvisoryIdentifiersType Read(
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
                        return global::G.RepositoryAdvisoryIdentifiersTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryAdvisoryIdentifiersType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryAdvisoryIdentifiersType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.RepositoryAdvisoryIdentifiersTypeExtensions.ToValueString(value));
        }
    }
}
