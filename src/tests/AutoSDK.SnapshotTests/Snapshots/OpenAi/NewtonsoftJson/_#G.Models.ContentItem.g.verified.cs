﻿//HintName: G.Models.ContentItem.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageFileObject? ImageFile { get; init; }
#else
        public global::G.MessageContentImageFileObject? ImageFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageFile))]
#endif
        public bool IsImageFile => ImageFile != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageContentImageFileObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageFileObject?(ContentItem @this) => @this.ImageFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageContentImageFileObject? value)
        {
            ImageFile = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentImageUrlObject? ImageUrl { get; init; }
#else
        public global::G.MessageContentImageUrlObject? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageContentImageUrlObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentImageUrlObject?(ContentItem @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageContentImageUrlObject? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentTextObject? Text { get; init; }
#else
        public global::G.MessageContentTextObject? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageContentTextObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentTextObject?(ContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageContentTextObject? value)
        {
            Text = value;
        }

        /// <summary>
        /// The refusal content generated by the assistant.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessageContentRefusalObject? Refusal { get; init; }
#else
        public global::G.MessageContentRefusalObject? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::G.MessageContentRefusalObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessageContentRefusalObject?(ContentItem @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::G.MessageContentRefusalObject? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::G.MessageObjectContentItemDiscriminatorType? type,
            global::G.MessageContentImageFileObject? imageFile,
            global::G.MessageContentImageUrlObject? imageUrl,
            global::G.MessageContentTextObject? text,
            global::G.MessageContentRefusalObject? refusal
            )
        {
            Type = type;

            ImageFile = imageFile;
            ImageUrl = imageUrl;
            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object ??
            ImageUrl as object ??
            ImageFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageFile && !IsImageUrl && !IsText && !IsRefusal || !IsImageFile && IsImageUrl && !IsText && !IsRefusal || !IsImageFile && !IsImageUrl && IsText && !IsRefusal || !IsImageFile && !IsImageUrl && !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessageContentImageFileObject?, TResult>? imageFile = null,
            global::System.Func<global::G.MessageContentImageUrlObject?, TResult>? imageUrl = null,
            global::System.Func<global::G.MessageContentTextObject?, TResult>? text = null,
            global::System.Func<global::G.MessageContentRefusalObject?, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile && imageFile != null)
            {
                return imageFile(ImageFile!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessageContentImageFileObject?>? imageFile = null,
            global::System.Action<global::G.MessageContentImageUrlObject?>? imageUrl = null,
            global::System.Action<global::G.MessageContentTextObject?>? text = null,
            global::System.Action<global::G.MessageContentRefusalObject?>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile)
            {
                imageFile?.Invoke(ImageFile!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageFile,
                typeof(global::G.MessageContentImageFileObject),
                ImageUrl,
                typeof(global::G.MessageContentImageUrlObject),
                Text,
                typeof(global::G.MessageContentTextObject),
                Refusal,
                typeof(global::G.MessageContentRefusalObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageFileObject?>.Default.Equals(ImageFile, other.ImageFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentImageUrlObject?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentTextObject?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessageContentRefusalObject?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ContentItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ContentItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
