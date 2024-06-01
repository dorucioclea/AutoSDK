﻿//HintName: JsonConverters.ReactionsListForPullRequestReviewCommentContent.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsListForPullRequestReviewCommentContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReactionsListForPullRequestReviewCommentContent>
    {
        /// <inheritdoc />
        public override global::G.ReactionsListForPullRequestReviewCommentContent Read(
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
                        return global::G.ReactionsListForPullRequestReviewCommentContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReactionsListForPullRequestReviewCommentContent)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReactionsListForPullRequestReviewCommentContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ReactionsListForPullRequestReviewCommentContentExtensions.ToValueString(value));
        }
    }
}
