﻿//HintName: G.Models.WebhookPullRequestReviewRequestRemoved.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookPullRequestReviewRequestRemoved : global::System.IEquatable<WebhookPullRequestReviewRequestRemoved>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestRemovedVariant1? Value1 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestRemovedVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant1 value) => new WebhookPullRequestReviewRequestRemoved(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestRemovedVariant1?(WebhookPullRequestReviewRequestRemoved @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookPullRequestReviewRequestRemovedVariant2? Value2 { get; init; }
#else
        public global::G.WebhookPullRequestReviewRequestRemovedVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant2 value) => new WebhookPullRequestReviewRequestRemoved(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookPullRequestReviewRequestRemovedVariant2?(WebhookPullRequestReviewRequestRemoved @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(global::G.WebhookPullRequestReviewRequestRemovedVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookPullRequestReviewRequestRemoved(
            global::G.WebhookPullRequestReviewRequestRemovedVariant1? value1,
            global::G.WebhookPullRequestReviewRequestRemovedVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1),
                Value2,
                typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2),
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
        public bool Equals(WebhookPullRequestReviewRequestRemoved other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestRemovedVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookPullRequestReviewRequestRemovedVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookPullRequestReviewRequestRemoved obj1, WebhookPullRequestReviewRequestRemoved obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookPullRequestReviewRequestRemoved>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookPullRequestReviewRequestRemoved obj1, WebhookPullRequestReviewRequestRemoved obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookPullRequestReviewRequestRemoved o && Equals(o);
        }
    }
}
