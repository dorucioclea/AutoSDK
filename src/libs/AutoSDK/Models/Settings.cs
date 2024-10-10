using System.Collections.Immutable;
using AutoSDK.Naming.Methods;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    string ClsCompliantEnumPrefix,
    NamingConvention NamingConvention,
    JsonSerializerType JsonSerializerType,
    SdkFeatureUsage UseRequiredKeyword,

    bool GenerateConstructors,
    bool GroupByTags,
    bool GenerateMethods,
    MethodNamingConvention MethodNamingConvention,
    MethodNamingConvention MethodNamingConventionFallback,
    bool GenerateMethodsAsHttpClientExtensions,
    bool GenerateMethodsUsingSystemNetHttpJson,
    ImmutableArray<string> IncludeOperationIds,
    ImmutableArray<string> ExcludeOperationIds,
    ImmutableArray<string> IncludeTags,
    ImmutableArray<string> ExcludeTags,
    bool ExcludeDeprecatedOperations,
    string JsonSerializerContext,
    bool GenerateJsonSerializerContextTypes,

    bool GenerateModels,
    bool ValidateAnyOfs,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels,
    ImmutableArray<string> ExcludeModels,
    
    bool IgnoreOpenApiErrors,
    bool IgnoreOpenApiWarnings,

    bool GeneratePolyfills,

    bool GenerateSdk,
    bool FromCli)
{
    public static Settings Default => new(
        TargetFramework: "net8.0",
        Namespace: string.Empty,
        ClassName: string.Empty,
        ClsCompliantEnumPrefix: string.Empty,
        NamingConvention: default,
        JsonSerializerType: default,
        UseRequiredKeyword: default,
        GenerateConstructors: false,
        GroupByTags: true,
        GenerateMethods: false,
        MethodNamingConvention: default,
        MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
        GenerateMethodsAsHttpClientExtensions: false,
        GenerateMethodsUsingSystemNetHttpJson: false,
        IncludeOperationIds: ImmutableArray<string>.Empty,
        ExcludeOperationIds: ImmutableArray<string>.Empty,
        IncludeTags: ImmutableArray<string>.Empty,
        ExcludeTags: ImmutableArray<string>.Empty,
        ExcludeDeprecatedOperations: false,
        JsonSerializerContext: string.Empty,
        GenerateJsonSerializerContextTypes: false,
        GenerateModels: false,
        ValidateAnyOfs: false,
        ModelStyle: default,
        IncludeModels: ImmutableArray<string>.Empty,
        ExcludeModels: ImmutableArray<string>.Empty,
        IgnoreOpenApiErrors: false,
        IgnoreOpenApiWarnings: true,
        GeneratePolyfills: true,
        GenerateSdk: true,
        FromCli: false
    );
}