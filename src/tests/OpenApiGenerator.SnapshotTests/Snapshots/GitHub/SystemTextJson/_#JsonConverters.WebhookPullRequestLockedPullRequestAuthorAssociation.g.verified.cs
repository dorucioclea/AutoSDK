﻿//HintName: JsonConverters.WebhookPullRequestLockedPullRequestAuthorAssociation.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestLockedPullRequestAuthorAssociationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestLockedPullRequestAuthorAssociation>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestLockedPullRequestAuthorAssociation Read(
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
                        return global::G.WebhookPullRequestLockedPullRequestAuthorAssociationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestLockedPullRequestAuthorAssociation)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestLockedPullRequestAuthorAssociation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookPullRequestLockedPullRequestAuthorAssociationExtensions.ToValueString(value));
        }
    }
}
