﻿//HintName: JsonConverters.WebhooksPullRequest5BaseRepoVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPullRequest5BaseRepoVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksPullRequest5BaseRepoVisibility>
    {
        /// <inheritdoc />
        public override global::G.WebhooksPullRequest5BaseRepoVisibility Read(
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
                        return global::G.WebhooksPullRequest5BaseRepoVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksPullRequest5BaseRepoVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksPullRequest5BaseRepoVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhooksPullRequest5BaseRepoVisibilityExtensions.ToValueString(value));
        }
    }
}
