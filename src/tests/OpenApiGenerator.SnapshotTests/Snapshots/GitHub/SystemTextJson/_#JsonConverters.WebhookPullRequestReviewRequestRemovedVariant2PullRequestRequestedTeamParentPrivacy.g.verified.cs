﻿//HintName: JsonConverters.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy Read(
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
                        return global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyExtensions.ToValueString(value));
        }
    }
}
