﻿//HintName: JsonConverters.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueVariant1ActiveLockReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason Read(
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
                        return global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssueCommentCreatedIssueVariant1ActiveLockReasonExtensions.ToValueString(value));
        }
    }
}
