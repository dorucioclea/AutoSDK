﻿//HintName: JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration Read(
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
                        return global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministrationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministrationExtensions.ToValueString(value));
        }
    }
}
