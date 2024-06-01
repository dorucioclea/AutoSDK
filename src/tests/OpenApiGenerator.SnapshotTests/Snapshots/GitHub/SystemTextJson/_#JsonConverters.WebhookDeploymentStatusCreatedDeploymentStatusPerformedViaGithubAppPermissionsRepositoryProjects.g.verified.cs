﻿//HintName: JsonConverters.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjects.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjects>
    {
        /// <inheritdoc />
        public override global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjects Read(
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
                        return global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjects)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjects value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToValueString(value));
        }
    }
}
