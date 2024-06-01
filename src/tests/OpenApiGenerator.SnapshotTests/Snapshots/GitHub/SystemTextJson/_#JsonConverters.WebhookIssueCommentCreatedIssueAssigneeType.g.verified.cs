﻿//HintName: JsonConverters.WebhookIssueCommentCreatedIssueAssigneeType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueAssigneeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentCreatedIssueAssigneeType>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueAssigneeType Read(
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
                        return global::G.WebhookIssueCommentCreatedIssueAssigneeTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentCreatedIssueAssigneeType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueAssigneeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssueCommentCreatedIssueAssigneeTypeExtensions.ToValueString(value));
        }
    }
}
