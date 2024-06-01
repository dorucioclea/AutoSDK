﻿//HintName: JsonConverters.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility>
    {
        /// <inheritdoc />
        public override global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility Read(
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
                        return global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibilityExtensions.ToValueString(value));
        }
    }
}
