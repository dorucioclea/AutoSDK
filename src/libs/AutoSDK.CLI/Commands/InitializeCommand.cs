using System.CommandLine;
using System.Globalization;

namespace AutoSDK.CLI.Commands;

internal sealed class InitializeCommand : Command
{
    public InitializeCommand() : base(name: "init", description: "Creates a new solution with GitHub Actions.")
    {
        var solutionName = new Argument<string>(
            name: "solution-name",
            getDefaultValue: () => string.Empty,
            description: "Solution name");
        var clientName = new Argument<string>(
            name: "client-name",
            getDefaultValue: () => string.Empty,
            description: "API client name");
        var openApiSpec = new Argument<string>(
            name: "open-api-spec",
            getDefaultValue: () => string.Empty,
            description: "OpenAPI spec url");
        var company = new Argument<string>(
            name: "company",
            getDefaultValue: () => string.Empty,
            description: "Company name");
        var output = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => string.Empty,
            description: "Output directory");
        var addMkDocs = new Option<bool>(
            aliases: ["--add-mkdocs", "-m"],
            getDefaultValue: () => true,
            description: "Adds MkDocs to the solution");
        var addTests = new Option<bool>(
            aliases: ["--add-tests", "-t"],
            getDefaultValue: () => true,
            description: "Adds integration tests to the solution");
        AddArgument(solutionName);
        AddArgument(clientName);
        AddArgument(openApiSpec);
        AddArgument(company);
        AddOption(output);
        AddOption(addMkDocs);
        AddOption(addTests);

        this.SetHandler(
            HandleAsync,
            solutionName,
            clientName,
            openApiSpec,
            company,
            output,
            addMkDocs,
            addTests);
    }

    private static async Task HandleAsync(
        string solutionName,
        string clientName,
        string openApiSpec,
        string company,
        string outputPath,
        bool addMkDocs,
        bool addTests)
    {
        Console.WriteLine("Initializing...");

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            outputPath = Path.Combine(Directory.GetCurrentDirectory(), solutionName);
        }
        else
        {
            Directory.CreateDirectory(outputPath);
        }

        var resources = new List<H.Resource>
        {
            H.Resources.__gitignore,
            H.Resources.__SolutionName__sln,
            H.Resources.__github_dependabot_yml,
            H.Resources.__github_workflows_auto_merge_yml,
            H.Resources.__github_workflows_auto_update_yml,
            H.Resources.__github_workflows_dotnet_yml,
            H.Resources.__github_workflows_pull_request_yml,
            H.Resources.assets_nuget_icon_png,
            H.Resources.global_json,
            H.Resources.LICENSE,
            H.Resources.README_md,
            H.Resources.src_Directory_Build_props,
            H.Resources.src_helpers_FixOpenApiSpec_FixOpenApiSpec_csproj,
            H.Resources.src_helpers_FixOpenApiSpec_Program_cs,
            H.Resources.src_helpers_FixOpenApiSpec_Properties_launchSettings_json,
            H.Resources.src_helpers_TrimmingHelper_Program_cs,
            H.Resources.src_helpers_TrimmingHelper_TrimmingHelper_csproj,
            H.Resources.src_key_snk,
            H.Resources.src_libs__SolutionName___SolutionName__csproj,
            H.Resources.src_libs__SolutionName__generate_sh,
            H.Resources.src_libs_Directory_Build_props,
        };
        var replaces = new Dictionary<string, string>();
        if (addMkDocs)
        {
            resources.AddRange(new []
            {
                H.Resources.__github_workflows_mkdocs_yml,
                H.Resources.docs_css_extra_css,
                H.Resources.docs_media_icon128_png,
                H.Resources.mkdocs_yml,
                H.Resources.src_helpers_GenerateDocs_GenerateDocs_csproj,
                H.Resources.src_helpers_GenerateDocs_Program_cs,
            });
        }
        if (addTests)
        {
            resources.AddRange(new []
            {
                H.Resources.src_tests_IntegrationTests__SolutionName__IntegrationTests_csproj,
                H.Resources.src_tests_IntegrationTests_Tests_cs,
                H.Resources.src_tests_IntegrationTests_Tests_Test_cs,
            });
        }
        else
        {
            replaces.Add(@"Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""$SolutionName$.IntegrationTests"", ""src\tests\IntegrationTests\$SolutionName$.IntegrationTests.csproj"", ""{592ADBC9-C951-4AF7-A163-B6C63B970B19}""
EndProject", string.Empty);
            replaces.Add(@"
		{592ADBC9-C951-4AF7-A163-B6C63B970B19}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{592ADBC9-C951-4AF7-A163-B6C63B970B19}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{592ADBC9-C951-4AF7-A163-B6C63B970B19}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{592ADBC9-C951-4AF7-A163-B6C63B970B19}.Release|Any CPU.Build.0 = Release|Any CPU", string.Empty);
            replaces.Add(@"
		{592ADBC9-C951-4AF7-A163-B6C63B970B19} = {AAA11B78-2764-4520-A97E-46AA7089A588}", string.Empty);
        }
        
        foreach (var resource in resources)
        {
            var path = Path.Combine(outputPath, Replace(resource.FileName)
                .Replace("_", Path.DirectorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase));
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            
            var extension = Path.GetExtension(path);
            if (extension.ToUpperInvariant() is ".PNG" or ".JPG" or ".JPEG" or ".GIF" or ".SVG" or ".SNK")
            {
                await File.WriteAllBytesAsync(
                    path,
                    resource.AsBytes()).ConfigureAwait(false);
            }
            else
            {
                await File.WriteAllTextAsync(
                    path,
                    Replace(resource.AsString())).ConfigureAwait(false);
            }
        }

        Console.WriteLine("Done.");
        return;
        
        string Replace(string content)
        {
            var newContent = content;
            
            foreach (var (key, value) in replaces)
            {
                newContent = newContent.Replace(key, value, StringComparison.OrdinalIgnoreCase);
            }
            
            newContent = newContent
                .Replace("$SolutionName$", solutionName, StringComparison.OrdinalIgnoreCase)
                .Replace("$ClientName$", clientName, StringComparison.OrdinalIgnoreCase)
                .Replace("$OpenApiSpec$", openApiSpec, StringComparison.OrdinalIgnoreCase)
                .Replace("$CurrentYear$", DateTime.Now.Year.ToString(CultureInfo.InvariantCulture), StringComparison.OrdinalIgnoreCase)
                .Replace("$CompanyName$", company, StringComparison.OrdinalIgnoreCase)
                .Replace("$SolutionNameUppercase$", solutionName.ToUpperInvariant(), StringComparison.OrdinalIgnoreCase)
                ;
            
            return newContent;
        }
    }
}