﻿//HintName: JsonConverters.PackagesListPackagesForAuthenticatedUserVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class PackagesListPackagesForAuthenticatedUserVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PackagesListPackagesForAuthenticatedUserVisibility>
    {
        /// <inheritdoc />
        public override global::G.PackagesListPackagesForAuthenticatedUserVisibility Read(
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
                        return global::G.PackagesListPackagesForAuthenticatedUserVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PackagesListPackagesForAuthenticatedUserVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PackagesListPackagesForAuthenticatedUserVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.PackagesListPackagesForAuthenticatedUserVisibilityExtensions.ToValueString(value));
        }
    }
}
