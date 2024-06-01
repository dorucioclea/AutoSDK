﻿//HintName: OneOf.1.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct OneOf<T1> : global::System.IEquatable<OneOf<T1>>
    {
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        public static implicit operator OneOf<T1>(T1 value) => new OneOf<T1>(value);

        public static implicit operator T1?(OneOf<T1> @this) => @this.Value1;

        public OneOf(T1? value)
        {
            Value1 = value;
        }

        public bool Validate()
        {
            return !IsValue1;
        }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(OneOf<T1> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) 
                ;
        }

        public static bool operator ==(OneOf<T1> obj1, OneOf<T1> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OneOf<T1>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(OneOf<T1> obj1, OneOf<T1> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is OneOf<T1> o && Equals(o);
        }
    }
}
