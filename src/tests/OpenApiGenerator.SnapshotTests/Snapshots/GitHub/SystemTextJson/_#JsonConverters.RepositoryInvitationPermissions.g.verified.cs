﻿//HintName: JsonConverters.RepositoryInvitationPermissions.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryInvitationPermissionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryInvitationPermissions>
    {
        /// <inheritdoc />
        public override global::G.RepositoryInvitationPermissions Read(
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
                        return global::G.RepositoryInvitationPermissionsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryInvitationPermissions)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryInvitationPermissions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.RepositoryInvitationPermissionsExtensions.ToValueString(value));
        }
    }
}
