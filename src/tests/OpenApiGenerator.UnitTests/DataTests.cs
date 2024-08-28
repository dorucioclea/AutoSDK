﻿using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

public partial class DataTests
{
    [TestMethod]
    public Task OpenAi()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.openai_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task Ollama()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.ollama_yaml.AsString(),
            DefaultSettings with
            {
                GenerateJsonSerializerContextTypes = true,
            })));
    }

    [TestMethod]
    public Task Replicate()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.replicate_json.AsString(),
            DefaultSettings with
            {
                MethodNamingConvention = MethodNamingConvention.OperationIdWithDots,
            })));
    }
    
    [TestMethod]
    public Task GitHub()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.github_yaml.AsString(),
            DefaultSettings)));
    }
    
    [TestMethod]
    public Task Leonardo()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.leonardo_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task LangSmith()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.langsmith_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task SpecialCases()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.specialcases_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task Dedoose()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.dedoose_json.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task Ai21()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.ai21_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task HuggingFace()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.huggingface_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task Cohere()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.cohere_yaml.AsString(),
            DefaultSettings)));
    }
}