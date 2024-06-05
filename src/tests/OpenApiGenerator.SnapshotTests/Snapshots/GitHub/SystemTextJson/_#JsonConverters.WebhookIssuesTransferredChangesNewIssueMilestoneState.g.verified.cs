﻿//HintName: JsonConverters.WebhookIssuesTransferredChangesNewIssueMilestoneState.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesTransferredChangesNewIssueMilestoneStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesTransferredChangesNewIssueMilestoneState>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesTransferredChangesNewIssueMilestoneState Read(
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
                        return global::G.WebhookIssuesTransferredChangesNewIssueMilestoneStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesTransferredChangesNewIssueMilestoneState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesTransferredChangesNewIssueMilestoneState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssuesTransferredChangesNewIssueMilestoneStateExtensions.ToValueString(value));
        }
    }
}