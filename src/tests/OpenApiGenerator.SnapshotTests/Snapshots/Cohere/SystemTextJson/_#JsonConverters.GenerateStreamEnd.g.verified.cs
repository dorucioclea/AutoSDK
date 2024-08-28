﻿//HintName: JsonConverters.GenerateStreamEnd.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamEndJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateStreamEnd>
    {
        /// <inheritdoc />
        public override global::G.GenerateStreamEnd Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.GenerateStreamEvent? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.GenerateStreamEndVariant2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEndVariant2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.GenerateStreamEnd(
                value1,
                value2
                );

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEvent>(ref reader, options);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerateStreamEndVariant2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateStreamEnd value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.GenerateStreamEvent), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.GenerateStreamEndVariant2), options);
            }
        }
    }
}