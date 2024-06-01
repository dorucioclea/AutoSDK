﻿//HintName: G.Models.RepositoryAdvisoryCreditState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the user's acceptance of the credit.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryCreditState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accepted")]
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="declined")]
        Declined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryCreditStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreditState value)
        {
            return value switch
            {
                RepositoryAdvisoryCreditState.Accepted => "accepted",
                RepositoryAdvisoryCreditState.Declined => "declined",
                RepositoryAdvisoryCreditState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreditState ToEnum(string value)
        {
            return value switch
            {
                "accepted" => RepositoryAdvisoryCreditState.Accepted,
                "declined" => RepositoryAdvisoryCreditState.Declined,
                "pending" => RepositoryAdvisoryCreditState.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}