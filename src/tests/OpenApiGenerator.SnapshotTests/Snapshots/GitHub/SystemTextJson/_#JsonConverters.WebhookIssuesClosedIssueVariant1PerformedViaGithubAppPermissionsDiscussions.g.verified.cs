﻿//HintName: JsonConverters.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions Read(
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
                        return global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToValueString(value));
        }
    }
}
