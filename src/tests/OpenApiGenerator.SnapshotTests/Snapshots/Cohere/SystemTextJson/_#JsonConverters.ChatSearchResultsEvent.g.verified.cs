﻿//HintName: JsonConverters.ChatSearchResultsEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatSearchResultsEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatSearchResultsEvent>
    {
        /// <inheritdoc />
        public override global::G.ChatSearchResultsEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatStreamEvent? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatSearchResultsEventVariant2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchResultsEventVariant2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatSearchResultsEvent(
                value1,
                value2
                );

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEvent>(ref reader, options);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatSearchResultsEventVariant2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatSearchResultsEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.ChatStreamEvent), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.ChatSearchResultsEventVariant2), options);
            }
        }
    }
}