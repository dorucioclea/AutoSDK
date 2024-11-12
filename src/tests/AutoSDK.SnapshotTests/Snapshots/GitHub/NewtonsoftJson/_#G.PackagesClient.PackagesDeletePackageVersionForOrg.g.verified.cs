﻿//HintName: G.PackagesClient.PackagesDeletePackageVersionForOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesDeletePackageVersionForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesDeletePackageVersionForOrgPackageType packageType,
            ref string packageName,
            ref string org,
            ref int packageVersionId);
        partial void PreparePackagesDeletePackageVersionForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesDeletePackageVersionForOrgPackageType packageType,
            string packageName,
            string org,
            int packageVersionId);
        partial void ProcessPackagesDeletePackageVersionForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete package version for an organization<br/>
        /// Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.<br/>
        /// The authenticated user must have admin permissions in the organization to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must also have admin permissions to the package. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PackagesDeletePackageVersionForOrgAsync(
            global::G.PackagesDeletePackageVersionForOrgPackageType packageType,
            string packageName,
            string org,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesDeletePackageVersionForOrgArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                org: ref org,
                packageVersionId: ref packageVersionId);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesDeletePackageVersionForOrgPackageType.Npm => "npm",
                global::G.PackagesDeletePackageVersionForOrgPackageType.Maven => "maven",
                global::G.PackagesDeletePackageVersionForOrgPackageType.Rubygems => "rubygems",
                global::G.PackagesDeletePackageVersionForOrgPackageType.Docker => "docker",
                global::G.PackagesDeletePackageVersionForOrgPackageType.Nuget => "nuget",
                global::G.PackagesDeletePackageVersionForOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/packages/{packageTypeValue}/{packageName}/versions/{packageVersionId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesDeletePackageVersionForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                packageName: packageName,
                org: org,
                packageVersionId: packageVersionId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesDeletePackageVersionForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}