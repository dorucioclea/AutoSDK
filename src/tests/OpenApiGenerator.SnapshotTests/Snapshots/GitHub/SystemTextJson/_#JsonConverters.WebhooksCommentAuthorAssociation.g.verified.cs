﻿//HintName: JsonConverters.WebhooksCommentAuthorAssociation.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksCommentAuthorAssociationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksCommentAuthorAssociation>
    {
        /// <inheritdoc />
        public override global::G.WebhooksCommentAuthorAssociation Read(
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
                        return global::G.WebhooksCommentAuthorAssociationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksCommentAuthorAssociation)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksCommentAuthorAssociation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhooksCommentAuthorAssociationExtensions.ToValueString(value));
        }
    }
}
