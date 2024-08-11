﻿//HintName: G.Models.RepositoryRuleDetailed.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A repository rule with ruleset details.
    /// </summary>
    public readonly partial struct RepositoryRuleDetailed : global::System.IEquatable<RepositoryRuleDetailed>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>? Value1 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>? Value1 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>? Value2 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>? Value2 { get; }
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
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>? Value3 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>? Value4 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>? Value5 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>? Value6 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>? Value7 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>? Value8 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>? Value9 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>? Value10 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? Value11 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? Value12 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>? Value13 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>? Value14 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>? Value15 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>? Value16 { get; init; }
#else
        public global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?> value) => new RepositoryRuleDetailed(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>?(RepositoryRuleDetailed @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(
            global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>? value1,
            global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>? value2,
            global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>? value3,
            global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>? value4,
            global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>? value5,
            global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>? value6,
            global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>? value7,
            global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>? value8,
            global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>? value9,
            global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>? value10,
            global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value11,
            global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>? value12,
            global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value13,
            global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>? value14,
            global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>? value15,
            global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>? value16
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>),
                Value2,
                typeof(global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>),
                Value3,
                typeof(global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>),
                Value4,
                typeof(global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>),
                Value5,
                typeof(global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>),
                Value6,
                typeof(global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>),
                Value7,
                typeof(global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>),
                Value8,
                typeof(global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>),
                Value9,
                typeof(global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>),
                Value10,
                typeof(global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>),
                Value11,
                typeof(global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>),
                Value12,
                typeof(global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>),
                Value13,
                typeof(global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>),
                Value14,
                typeof(global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>),
                Value15,
                typeof(global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>),
                Value16,
                typeof(global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>),
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
        public bool Equals(RepositoryRuleDetailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleCreation?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleUpdate?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleDeletion?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleRequiredLinearHistory?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleRequiredDeployments?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleRequiredSignatures?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRulePullRequest?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleRequiredStatusChecks?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleNonFastForward?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleCommitMessagePattern?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleCommitterEmailPattern?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleBranchNamePattern?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleTagNamePattern?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleWorkflows?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::System.AllOf<global::G.RepositoryRuleCodeScanning?, global::G.RepositoryRuleRulesetInfo?>?>.Default.Equals(Value16, other.Value16) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRuleDetailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRuleDetailed o && Equals(o);
        }
    }
}
