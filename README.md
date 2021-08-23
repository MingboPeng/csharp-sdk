[![Build](https://pollination.cloud-dotnet/workflows/CD/badge.svg)](https://pollination.cloud-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/PollinationSDK?dWidth=50)](https://www.nuget.org/packages/PollinationSDK)

# PollinationSDK - the C# library for the pollination-server

Pollination Server OpenAPI Definition

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.14.0
- SDK version: 0.14.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://pollination.cloud](https://pollination.cloud)

## Frameworks supported


- .NET Core >=1.0
- .NET Framework >=4.5

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out PollinationSDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: APIKeyAuth
            Configuration.Default.ApiKey.Add("x-pollination-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-pollination-token", "Bearer");
            // Configure HTTP bearer authorization: JWTAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APITokensApi(Configuration.Default);
            var aPITokenCreate = new APITokenCreate(); // APITokenCreate | 

            try
            {
                // Create a new API token
                APITokenPrivate result = apiInstance.CreateToken(aPITokenCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling APITokensApi.CreateToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APITokensApi* | [**CreateToken**](docs/APITokensApi.md#createtoken) | **POST** /tokens | Create a new API token
*APITokensApi* | [**DeleteToken**](docs/APITokensApi.md#deletetoken) | **DELETE** /tokens/{token_id} | Delete an API Token
*APITokensApi* | [**ListTokens**](docs/APITokensApi.md#listtokens) | **GET** /tokens | List user API tokens
*APITokensApi* | [**RegenerateToken**](docs/APITokensApi.md#regeneratetoken) | **PUT** /tokens/{token_id} | Regenerate an API token
*AccountsApi* | [**GetAccount**](docs/AccountsApi.md#getaccount) | **GET** /accounts/{name} | Get an account by name
*AccountsApi* | [**ListAccounts**](docs/AccountsApi.md#listaccounts) | **GET** /accounts | List Accounts on the Pollination platform
*ArtifactsApi* | [**CreateArtifact**](docs/ArtifactsApi.md#createartifact) | **POST** /projects/{owner}/{name}/artifacts | Get an Artifact upload link.
*ArtifactsApi* | [**DeleteArtifact**](docs/ArtifactsApi.md#deleteartifact) | **DELETE** /projects/{owner}/{name}/artifacts | Delete one or many artifacts by key/prefix
*ArtifactsApi* | [**DownloadArtifact**](docs/ArtifactsApi.md#downloadartifact) | **GET** /projects/{owner}/{name}/artifacts/download | Download an artifact from the project folder
*ArtifactsApi* | [**ListArtifacts**](docs/ArtifactsApi.md#listartifacts) | **GET** /projects/{owner}/{name}/artifacts | List artifacts in a project folder
*JobsApi* | [**CancelJob**](docs/JobsApi.md#canceljob) | **PUT** /projects/{owner}/{name}/jobs/{job_id}/cancel | Cancel a Job
*JobsApi* | [**CreateJob**](docs/JobsApi.md#createjob) | **POST** /projects/{owner}/{name}/jobs | Schedule a job
*JobsApi* | [**DownloadJobArtifact**](docs/JobsApi.md#downloadjobartifact) | **GET** /projects/{owner}/{name}/jobs/{job_id}/artifacts/download | Download an artifact from the job folder
*JobsApi* | [**GetJob**](docs/JobsApi.md#getjob) | **GET** /projects/{owner}/{name}/jobs/{job_id} | Get a Job
*JobsApi* | [**ListJobs**](docs/JobsApi.md#listjobs) | **GET** /projects/{owner}/{name}/jobs | List Jobs
*JobsApi* | [**SearchJobFolder**](docs/JobsApi.md#searchjobfolder) | **GET** /projects/{owner}/{name}/jobs/{job_id}/artifacts | List files/folders in a job folder
*OrgsApi* | [**CreateOrg**](docs/OrgsApi.md#createorg) | **POST** /orgs | Create an Org
*OrgsApi* | [**DeleteOrg**](docs/OrgsApi.md#deleteorg) | **DELETE** /orgs/{name} | Delete an Org
*OrgsApi* | [**DeleteOrgMember**](docs/OrgsApi.md#deleteorgmember) | **DELETE** /orgs/{name}/members/{username} | Remove an Org member
*OrgsApi* | [**GetOrg**](docs/OrgsApi.md#getorg) | **GET** /orgs/{name} | Get an Org
*OrgsApi* | [**GetOrgMembers**](docs/OrgsApi.md#getorgmembers) | **GET** /orgs/{name}/members | List organization members
*OrgsApi* | [**ListOrgs**](docs/OrgsApi.md#listorgs) | **GET** /orgs | List Orgs
*OrgsApi* | [**UpdateOrg**](docs/OrgsApi.md#updateorg) | **PUT** /orgs/{name} | Update an Org
*OrgsApi* | [**UpsertOrgMember**](docs/OrgsApi.md#upsertorgmember) | **PATCH** /orgs/{name}/members/{username}/{role} | Add or update the role of an Org Member
*PluginsApi* | [**CreatePlugin**](docs/PluginsApi.md#createplugin) | **POST** /plugins/{owner} | Create a Plugin
*PluginsApi* | [**CreatePluginPackage**](docs/PluginsApi.md#createpluginpackage) | **POST** /plugins/{owner}/{name}/tags | Create a new Plugin package
*PluginsApi* | [**DeletePlugin**](docs/PluginsApi.md#deleteplugin) | **DELETE** /plugins/{owner}/{name} | Delete a Plugin
*PluginsApi* | [**DeletePluginOrgPermission**](docs/PluginsApi.md#deletepluginorgpermission) | **DELETE** /plugins/{owner}/{name}/permissions | Remove a Repository permissions
*PluginsApi* | [**GetPlugin**](docs/PluginsApi.md#getplugin) | **GET** /plugins/{owner}/{name} | Get a plugin
*PluginsApi* | [**GetPluginAccessPermissions**](docs/PluginsApi.md#getpluginaccesspermissions) | **GET** /plugins/{owner}/{name}/permissions | Get plugin access permissions
*PluginsApi* | [**GetPluginByTag**](docs/PluginsApi.md#getpluginbytag) | **GET** /plugins/{owner}/{name}/tags/{tag} | Get a plugin tag
*PluginsApi* | [**ListPluginTags**](docs/PluginsApi.md#listplugintags) | **GET** /plugins/{owner}/{name}/tags | Get a plugin tags
*PluginsApi* | [**ListPlugins**](docs/PluginsApi.md#listplugins) | **GET** /plugins | List plugins
*PluginsApi* | [**UpdatePlugin**](docs/PluginsApi.md#updateplugin) | **PUT** /plugins/{owner}/{name} | Update a Plugin
*PluginsApi* | [**UpsertPluginPermission**](docs/PluginsApi.md#upsertpluginpermission) | **PATCH** /plugins/{owner}/{name}/permissions | Upsert a new permission to a plugin
*ProjectsApi* | [**CreateProject**](docs/ProjectsApi.md#createproject) | **POST** /projects/{owner} | Create a Project
*ProjectsApi* | [**CreateProjectRecipeFilter**](docs/ProjectsApi.md#createprojectrecipefilter) | **POST** /projects/{owner}/{name}/recipes/filters | Upsert a recipe filter to a project
*ProjectsApi* | [**DeleteProject**](docs/ProjectsApi.md#deleteproject) | **DELETE** /projects/{owner}/{name} | Delete a Project
*ProjectsApi* | [**DeleteProjectOrgPermission**](docs/ProjectsApi.md#deleteprojectorgpermission) | **DELETE** /projects/{owner}/{name}/permissions | Remove a Project permissions
*ProjectsApi* | [**DeleteProjectRecipeFilter**](docs/ProjectsApi.md#deleteprojectrecipefilter) | **DELETE** /projects/{owner}/{name}/recipes/filters | Remove a Project recipe filter
*ProjectsApi* | [**GetProject**](docs/ProjectsApi.md#getproject) | **GET** /projects/{owner}/{name} | Get a project
*ProjectsApi* | [**GetProjectAccessPermissions**](docs/ProjectsApi.md#getprojectaccesspermissions) | **GET** /projects/{owner}/{name}/permissions | Get project access permissions
*ProjectsApi* | [**GetProjectRecipeFilters**](docs/ProjectsApi.md#getprojectrecipefilters) | **GET** /projects/{owner}/{name}/recipes/filters | Get project recipe filters
*ProjectsApi* | [**GetProjectRecipes**](docs/ProjectsApi.md#getprojectrecipes) | **GET** /projects/{owner}/{name}/recipes | Get project recipes
*ProjectsApi* | [**ListProjects**](docs/ProjectsApi.md#listprojects) | **GET** /projects | List Projects
*ProjectsApi* | [**Update**](docs/ProjectsApi.md#update) | **PUT** /projects/{owner}/{name} | Update a Project
*ProjectsApi* | [**UpsertProjectPermission**](docs/ProjectsApi.md#upsertprojectpermission) | **PATCH** /projects/{owner}/{name}/permissions | Upsert a new permission to a project
*RecipesApi* | [**CreateRecipe**](docs/RecipesApi.md#createrecipe) | **POST** /recipes/{owner} | Create a Recipe
*RecipesApi* | [**CreateRecipePackage**](docs/RecipesApi.md#createrecipepackage) | **POST** /recipes/{owner}/{name}/tags | Create a new Recipe package
*RecipesApi* | [**DeleteRecipe**](docs/RecipesApi.md#deleterecipe) | **DELETE** /recipes/{owner}/{name} | Delete a Recipe
*RecipesApi* | [**DeleteRecipeOrgPermission**](docs/RecipesApi.md#deleterecipeorgpermission) | **DELETE** /recipes/{owner}/{name}/permissions | Remove a Repository permissions
*RecipesApi* | [**GetRecipe**](docs/RecipesApi.md#getrecipe) | **GET** /recipes/{owner}/{name} | Get a recipe
*RecipesApi* | [**GetRecipeAccessPermissions**](docs/RecipesApi.md#getrecipeaccesspermissions) | **GET** /recipes/{owner}/{name}/permissions | Get recipe access permissions
*RecipesApi* | [**GetRecipeByTag**](docs/RecipesApi.md#getrecipebytag) | **GET** /recipes/{owner}/{name}/tags/{tag} | Get a recipe tag
*RecipesApi* | [**ListRecipeTags**](docs/RecipesApi.md#listrecipetags) | **GET** /recipes/{owner}/{name}/tags | Get a recipe tags
*RecipesApi* | [**ListRecipes**](docs/RecipesApi.md#listrecipes) | **GET** /recipes | List recipes
*RecipesApi* | [**UpdateRecipe**](docs/RecipesApi.md#updaterecipe) | **PUT** /recipes/{owner}/{name} | Update a Recipe
*RecipesApi* | [**UpsertRecipePermission**](docs/RecipesApi.md#upsertrecipepermission) | **PATCH** /recipes/{owner}/{name}/permissions | Upsert a new permission to a recipe
*RegistriesApi* | [**GetPackage**](docs/RegistriesApi.md#getpackage) | **GET** /registries/{owner}/{type}/{name}/{digest} | Get Package
*RegistriesApi* | [**GetPackageJson**](docs/RegistriesApi.md#getpackagejson) | **GET** /registries/{owner}/{type}/{name}/{digest}/json | Get Package in JSON format
*RegistriesApi* | [**GetRegistryIndex**](docs/RegistriesApi.md#getregistryindex) | **GET** /registries/{owner}/index.json | Get Registry Index
*RegistriesApi* | [**PostPlugin**](docs/RegistriesApi.md#postplugin) | **POST** /registries/{owner}/plugins | Push a plugin to the registry
*RegistriesApi* | [**PostRecipe**](docs/RegistriesApi.md#postrecipe) | **POST** /registries/{owner}/recipes | Push an Recipe to the registry
*RunsApi* | [**CancelRun**](docs/RunsApi.md#cancelrun) | **PUT** /projects/{owner}/{name}/runs/{run_id}/cancel | Cancel a run
*RunsApi* | [**DownloadRunArtifact**](docs/RunsApi.md#downloadrunartifact) | **GET** /projects/{owner}/{name}/runs/{run_id}/artifacts/download | Download an artifact from the run folder
*RunsApi* | [**GetRun**](docs/RunsApi.md#getrun) | **GET** /projects/{owner}/{name}/runs/{run_id} | Get a Run
*RunsApi* | [**GetRunOutput**](docs/RunsApi.md#getrunoutput) | **GET** /projects/{owner}/{name}/runs/{run_id}/outputs/{output_name} | Get run output by name
*RunsApi* | [**GetRunStepLogs**](docs/RunsApi.md#getrunsteplogs) | **GET** /projects/{owner}/{name}/runs/{run_id}/steps/{step_id}/logs | Get the logs of a specific step of the run
*RunsApi* | [**GetRunSteps**](docs/RunsApi.md#getrunsteps) | **GET** /projects/{owner}/{name}/runs/{run_id}/steps | Query the steps of a run
*RunsApi* | [**ListRunArtifacts**](docs/RunsApi.md#listrunartifacts) | **GET** /projects/{owner}/{name}/runs/{run_id}/artifacts | List artifacts in a run folder
*RunsApi* | [**ListRuns**](docs/RunsApi.md#listruns) | **GET** /projects/{owner}/{name}/runs | List runs
*RunsApi* | [**QueryResults**](docs/RunsApi.md#queryresults) | **GET** /projects/{owner}/{name}/results | Query run results
*TeamsApi* | [**CreateTeam**](docs/TeamsApi.md#createteam) | **POST** /orgs/{org_name}/teams | Create a Team
*TeamsApi* | [**DeleteOrgTeamMember**](docs/TeamsApi.md#deleteorgteammember) | **DELETE** /orgs/{org_name}/teams/{team_slug}/members/{username} | Remove a team member
*TeamsApi* | [**DeleteTeam**](docs/TeamsApi.md#deleteteam) | **DELETE** /orgs/{org_name}/teams/{team_slug} | Delete a Team
*TeamsApi* | [**GetOrgTeamMembers**](docs/TeamsApi.md#getorgteammembers) | **GET** /orgs/{org_name}/teams/{team_slug}/members | List team members
*TeamsApi* | [**GetTeam**](docs/TeamsApi.md#getteam) | **GET** /orgs/{org_name}/teams/{team_slug} | Get a Team
*TeamsApi* | [**ListOrgTeams**](docs/TeamsApi.md#listorgteams) | **GET** /orgs/{org_name}/teams | List Teams
*TeamsApi* | [**UpdateTeam**](docs/TeamsApi.md#updateteam) | **PUT** /orgs/{org_name}/teams/{team_slug} | Update a Team
*TeamsApi* | [**UpsertOrgTeamMember**](docs/TeamsApi.md#upsertorgteammember) | **PATCH** /orgs/{org_name}/teams/{team_slug}/members/{username}/{role} | Add or update the role of an Team Member
*UserApi* | [**CreateUser**](docs/UserApi.md#createuser) | **POST** /user | Register a new user
*UserApi* | [**GetMe**](docs/UserApi.md#getme) | **GET** /user | Get authenticated user profile.
*UserApi* | [**GetRoles**](docs/UserApi.md#getroles) | **GET** /user/roles | Get the authenticated user roles
*UserApi* | [**UpdateUserProfile**](docs/UserApi.md#updateuserprofile) | **PUT** /user | Update the authenticated user
*UsersApi* | [**CheckUsername**](docs/UsersApi.md#checkusername) | **GET** /users/check_username/{username} | Check if a username is already taken
*UsersApi* | [**GetOneUser**](docs/UsersApi.md#getoneuser) | **GET** /users/{name} | Get a specific user profile
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /users | List Users


## Documentation for Models

 - [Model.APIToken](docs/APIToken.md)
 - [Model.APITokenAllOf](docs/APITokenAllOf.md)
 - [Model.APITokenCreate](docs/APITokenCreate.md)
 - [Model.APITokenCreateAllOf](docs/APITokenCreateAllOf.md)
 - [Model.APITokenList](docs/APITokenList.md)
 - [Model.APITokenListAllOf](docs/APITokenListAllOf.md)
 - [Model.APITokenPrivate](docs/APITokenPrivate.md)
 - [Model.APITokenPrivateAllOf](docs/APITokenPrivateAllOf.md)
 - [Model.AccessPolicy](docs/AccessPolicy.md)
 - [Model.AccessPolicyAllOf](docs/AccessPolicyAllOf.md)
 - [Model.AccessPolicyList](docs/AccessPolicyList.md)
 - [Model.AccessPolicyListAllOf](docs/AccessPolicyListAllOf.md)
 - [Model.AccountPublic](docs/AccountPublic.md)
 - [Model.AccountPublicAllOf](docs/AccountPublicAllOf.md)
 - [Model.ArtifactSource](docs/ArtifactSource.md)
 - [Model.ArtifactSourceAllOf](docs/ArtifactSourceAllOf.md)
 - [Model.BaseReference](docs/BaseReference.md)
 - [Model.BaseReferenceAllOf](docs/BaseReferenceAllOf.md)
 - [Model.BaseStatus](docs/BaseStatus.md)
 - [Model.BaseStatusAllOf](docs/BaseStatusAllOf.md)
 - [Model.BodyPostPluginOwnerPluginsPost](docs/BodyPostPluginOwnerPluginsPost.md)
 - [Model.BodyPostPluginOwnerPluginsPostAllOf](docs/BodyPostPluginOwnerPluginsPostAllOf.md)
 - [Model.BodyPostRecipeOwnerRecipesPost](docs/BodyPostRecipeOwnerRecipesPost.md)
 - [Model.BodyPostRecipeOwnerRecipesPostAllOf](docs/BodyPostRecipeOwnerRecipesPostAllOf.md)
 - [Model.CloudJob](docs/CloudJob.md)
 - [Model.CloudJobAllOf](docs/CloudJobAllOf.md)
 - [Model.CloudJobList](docs/CloudJobList.md)
 - [Model.CloudJobListAllOf](docs/CloudJobListAllOf.md)
 - [Model.CreatedContent](docs/CreatedContent.md)
 - [Model.CreatedContentAllOf](docs/CreatedContentAllOf.md)
 - [Model.DAG](docs/DAG.md)
 - [Model.DAGAllOf](docs/DAGAllOf.md)
 - [Model.DAGArrayInput](docs/DAGArrayInput.md)
 - [Model.DAGArrayInputAlias](docs/DAGArrayInputAlias.md)
 - [Model.DAGArrayInputAliasAllOf](docs/DAGArrayInputAliasAllOf.md)
 - [Model.DAGArrayInputAllOf](docs/DAGArrayInputAllOf.md)
 - [Model.DAGArrayOutput](docs/DAGArrayOutput.md)
 - [Model.DAGArrayOutputAlias](docs/DAGArrayOutputAlias.md)
 - [Model.DAGArrayOutputAliasAllOf](docs/DAGArrayOutputAliasAllOf.md)
 - [Model.DAGArrayOutputAllOf](docs/DAGArrayOutputAllOf.md)
 - [Model.DAGArtifactOutput](docs/DAGArtifactOutput.md)
 - [Model.DAGArtifactOutputAlias](docs/DAGArtifactOutputAlias.md)
 - [Model.DAGArtifactOutputAliasAllOf](docs/DAGArtifactOutputAliasAllOf.md)
 - [Model.DAGArtifactOutputAllOf](docs/DAGArtifactOutputAllOf.md)
 - [Model.DAGBooleanInput](docs/DAGBooleanInput.md)
 - [Model.DAGBooleanInputAlias](docs/DAGBooleanInputAlias.md)
 - [Model.DAGBooleanInputAliasAllOf](docs/DAGBooleanInputAliasAllOf.md)
 - [Model.DAGBooleanInputAllOf](docs/DAGBooleanInputAllOf.md)
 - [Model.DAGBooleanOutput](docs/DAGBooleanOutput.md)
 - [Model.DAGBooleanOutputAlias](docs/DAGBooleanOutputAlias.md)
 - [Model.DAGBooleanOutputAliasAllOf](docs/DAGBooleanOutputAliasAllOf.md)
 - [Model.DAGBooleanOutputAllOf](docs/DAGBooleanOutputAllOf.md)
 - [Model.DAGFileInput](docs/DAGFileInput.md)
 - [Model.DAGFileInputAlias](docs/DAGFileInputAlias.md)
 - [Model.DAGFileInputAliasAllOf](docs/DAGFileInputAliasAllOf.md)
 - [Model.DAGFileInputAllOf](docs/DAGFileInputAllOf.md)
 - [Model.DAGFileOutput](docs/DAGFileOutput.md)
 - [Model.DAGFileOutputAlias](docs/DAGFileOutputAlias.md)
 - [Model.DAGFileOutputAliasAllOf](docs/DAGFileOutputAliasAllOf.md)
 - [Model.DAGFileOutputAllOf](docs/DAGFileOutputAllOf.md)
 - [Model.DAGFolderInput](docs/DAGFolderInput.md)
 - [Model.DAGFolderInputAlias](docs/DAGFolderInputAlias.md)
 - [Model.DAGFolderInputAliasAllOf](docs/DAGFolderInputAliasAllOf.md)
 - [Model.DAGFolderInputAllOf](docs/DAGFolderInputAllOf.md)
 - [Model.DAGFolderOutput](docs/DAGFolderOutput.md)
 - [Model.DAGFolderOutputAlias](docs/DAGFolderOutputAlias.md)
 - [Model.DAGFolderOutputAliasAllOf](docs/DAGFolderOutputAliasAllOf.md)
 - [Model.DAGFolderOutputAllOf](docs/DAGFolderOutputAllOf.md)
 - [Model.DAGGenericInput](docs/DAGGenericInput.md)
 - [Model.DAGGenericInputAlias](docs/DAGGenericInputAlias.md)
 - [Model.DAGGenericInputAliasAllOf](docs/DAGGenericInputAliasAllOf.md)
 - [Model.DAGGenericInputAllOf](docs/DAGGenericInputAllOf.md)
 - [Model.DAGGenericOutput](docs/DAGGenericOutput.md)
 - [Model.DAGGenericOutputAlias](docs/DAGGenericOutputAlias.md)
 - [Model.DAGGenericOutputAliasAllOf](docs/DAGGenericOutputAliasAllOf.md)
 - [Model.DAGGenericOutputAllOf](docs/DAGGenericOutputAllOf.md)
 - [Model.DAGIntegerInput](docs/DAGIntegerInput.md)
 - [Model.DAGIntegerInputAlias](docs/DAGIntegerInputAlias.md)
 - [Model.DAGIntegerInputAliasAllOf](docs/DAGIntegerInputAliasAllOf.md)
 - [Model.DAGIntegerInputAllOf](docs/DAGIntegerInputAllOf.md)
 - [Model.DAGIntegerOutput](docs/DAGIntegerOutput.md)
 - [Model.DAGIntegerOutputAlias](docs/DAGIntegerOutputAlias.md)
 - [Model.DAGIntegerOutputAliasAllOf](docs/DAGIntegerOutputAliasAllOf.md)
 - [Model.DAGIntegerOutputAllOf](docs/DAGIntegerOutputAllOf.md)
 - [Model.DAGJSONObjectInput](docs/DAGJSONObjectInput.md)
 - [Model.DAGJSONObjectInputAlias](docs/DAGJSONObjectInputAlias.md)
 - [Model.DAGJSONObjectInputAliasAllOf](docs/DAGJSONObjectInputAliasAllOf.md)
 - [Model.DAGJSONObjectInputAllOf](docs/DAGJSONObjectInputAllOf.md)
 - [Model.DAGJSONObjectOutput](docs/DAGJSONObjectOutput.md)
 - [Model.DAGJSONObjectOutputAlias](docs/DAGJSONObjectOutputAlias.md)
 - [Model.DAGJSONObjectOutputAliasAllOf](docs/DAGJSONObjectOutputAliasAllOf.md)
 - [Model.DAGJSONObjectOutputAllOf](docs/DAGJSONObjectOutputAllOf.md)
 - [Model.DAGLinkedInputAlias](docs/DAGLinkedInputAlias.md)
 - [Model.DAGLinkedInputAliasAllOf](docs/DAGLinkedInputAliasAllOf.md)
 - [Model.DAGLinkedOutputAlias](docs/DAGLinkedOutputAlias.md)
 - [Model.DAGLinkedOutputAliasAllOf](docs/DAGLinkedOutputAliasAllOf.md)
 - [Model.DAGNumberInput](docs/DAGNumberInput.md)
 - [Model.DAGNumberInputAlias](docs/DAGNumberInputAlias.md)
 - [Model.DAGNumberInputAliasAllOf](docs/DAGNumberInputAliasAllOf.md)
 - [Model.DAGNumberInputAllOf](docs/DAGNumberInputAllOf.md)
 - [Model.DAGNumberOutput](docs/DAGNumberOutput.md)
 - [Model.DAGNumberOutputAlias](docs/DAGNumberOutputAlias.md)
 - [Model.DAGNumberOutputAliasAllOf](docs/DAGNumberOutputAliasAllOf.md)
 - [Model.DAGNumberOutputAllOf](docs/DAGNumberOutputAllOf.md)
 - [Model.DAGPathInput](docs/DAGPathInput.md)
 - [Model.DAGPathInputAlias](docs/DAGPathInputAlias.md)
 - [Model.DAGPathInputAliasAllOf](docs/DAGPathInputAliasAllOf.md)
 - [Model.DAGPathInputAllOf](docs/DAGPathInputAllOf.md)
 - [Model.DAGPathOutput](docs/DAGPathOutput.md)
 - [Model.DAGPathOutputAlias](docs/DAGPathOutputAlias.md)
 - [Model.DAGPathOutputAliasAllOf](docs/DAGPathOutputAliasAllOf.md)
 - [Model.DAGPathOutputAllOf](docs/DAGPathOutputAllOf.md)
 - [Model.DAGStringInput](docs/DAGStringInput.md)
 - [Model.DAGStringInputAlias](docs/DAGStringInputAlias.md)
 - [Model.DAGStringInputAliasAllOf](docs/DAGStringInputAliasAllOf.md)
 - [Model.DAGStringInputAllOf](docs/DAGStringInputAllOf.md)
 - [Model.DAGStringOutput](docs/DAGStringOutput.md)
 - [Model.DAGStringOutputAlias](docs/DAGStringOutputAlias.md)
 - [Model.DAGStringOutputAliasAllOf](docs/DAGStringOutputAliasAllOf.md)
 - [Model.DAGStringOutputAllOf](docs/DAGStringOutputAllOf.md)
 - [Model.DAGTask](docs/DAGTask.md)
 - [Model.DAGTaskAllOf](docs/DAGTaskAllOf.md)
 - [Model.DAGTaskLoop](docs/DAGTaskLoop.md)
 - [Model.DAGTaskLoopAllOf](docs/DAGTaskLoopAllOf.md)
 - [Model.DailyUsage](docs/DailyUsage.md)
 - [Model.DailyUsageAllOf](docs/DailyUsageAllOf.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.DependencyAllOf](docs/DependencyAllOf.md)
 - [Model.DependencyKind](docs/DependencyKind.md)
 - [Model.DockerConfig](docs/DockerConfig.md)
 - [Model.DockerConfigAllOf](docs/DockerConfigAllOf.md)
 - [Model.FileMeta](docs/FileMeta.md)
 - [Model.FileMetaAllOf](docs/FileMetaAllOf.md)
 - [Model.FileReference](docs/FileReference.md)
 - [Model.FileReferenceAllOf](docs/FileReferenceAllOf.md)
 - [Model.FolderReference](docs/FolderReference.md)
 - [Model.FolderReferenceAllOf](docs/FolderReferenceAllOf.md)
 - [Model.FromOutput](docs/FromOutput.md)
 - [Model.FromOutputAllOf](docs/FromOutputAllOf.md)
 - [Model.Function](docs/Function.md)
 - [Model.FunctionAllOf](docs/FunctionAllOf.md)
 - [Model.FunctionArrayInput](docs/FunctionArrayInput.md)
 - [Model.FunctionArrayInputAllOf](docs/FunctionArrayInputAllOf.md)
 - [Model.FunctionArrayOutput](docs/FunctionArrayOutput.md)
 - [Model.FunctionArrayOutputAllOf](docs/FunctionArrayOutputAllOf.md)
 - [Model.FunctionBooleanInput](docs/FunctionBooleanInput.md)
 - [Model.FunctionBooleanInputAllOf](docs/FunctionBooleanInputAllOf.md)
 - [Model.FunctionBooleanOutput](docs/FunctionBooleanOutput.md)
 - [Model.FunctionBooleanOutputAllOf](docs/FunctionBooleanOutputAllOf.md)
 - [Model.FunctionFileInput](docs/FunctionFileInput.md)
 - [Model.FunctionFileInputAllOf](docs/FunctionFileInputAllOf.md)
 - [Model.FunctionFileOutput](docs/FunctionFileOutput.md)
 - [Model.FunctionFileOutputAllOf](docs/FunctionFileOutputAllOf.md)
 - [Model.FunctionFolderInput](docs/FunctionFolderInput.md)
 - [Model.FunctionFolderInputAllOf](docs/FunctionFolderInputAllOf.md)
 - [Model.FunctionFolderOutput](docs/FunctionFolderOutput.md)
 - [Model.FunctionFolderOutputAllOf](docs/FunctionFolderOutputAllOf.md)
 - [Model.FunctionIntegerInput](docs/FunctionIntegerInput.md)
 - [Model.FunctionIntegerInputAllOf](docs/FunctionIntegerInputAllOf.md)
 - [Model.FunctionIntegerOutput](docs/FunctionIntegerOutput.md)
 - [Model.FunctionIntegerOutputAllOf](docs/FunctionIntegerOutputAllOf.md)
 - [Model.FunctionJSONObjectInput](docs/FunctionJSONObjectInput.md)
 - [Model.FunctionJSONObjectInputAllOf](docs/FunctionJSONObjectInputAllOf.md)
 - [Model.FunctionJSONObjectOutput](docs/FunctionJSONObjectOutput.md)
 - [Model.FunctionJSONObjectOutputAllOf](docs/FunctionJSONObjectOutputAllOf.md)
 - [Model.FunctionNumberInput](docs/FunctionNumberInput.md)
 - [Model.FunctionNumberInputAllOf](docs/FunctionNumberInputAllOf.md)
 - [Model.FunctionNumberOutput](docs/FunctionNumberOutput.md)
 - [Model.FunctionNumberOutputAllOf](docs/FunctionNumberOutputAllOf.md)
 - [Model.FunctionPathInput](docs/FunctionPathInput.md)
 - [Model.FunctionPathInputAllOf](docs/FunctionPathInputAllOf.md)
 - [Model.FunctionPathOutput](docs/FunctionPathOutput.md)
 - [Model.FunctionPathOutputAllOf](docs/FunctionPathOutputAllOf.md)
 - [Model.FunctionStringInput](docs/FunctionStringInput.md)
 - [Model.FunctionStringInputAllOf](docs/FunctionStringInputAllOf.md)
 - [Model.FunctionStringOutput](docs/FunctionStringOutput.md)
 - [Model.FunctionStringOutputAllOf](docs/FunctionStringOutputAllOf.md)
 - [Model.GenericInput](docs/GenericInput.md)
 - [Model.GenericInputAllOf](docs/GenericInputAllOf.md)
 - [Model.GenericOutput](docs/GenericOutput.md)
 - [Model.GenericOutputAllOf](docs/GenericOutputAllOf.md)
 - [Model.HTTP](docs/HTTP.md)
 - [Model.HTTPAllOf](docs/HTTPAllOf.md)
 - [Model.IOAliasHandler](docs/IOAliasHandler.md)
 - [Model.IOAliasHandlerAllOf](docs/IOAliasHandlerAllOf.md)
 - [Model.IOBase](docs/IOBase.md)
 - [Model.IOBaseAllOf](docs/IOBaseAllOf.md)
 - [Model.InputFileReference](docs/InputFileReference.md)
 - [Model.InputFileReferenceAllOf](docs/InputFileReferenceAllOf.md)
 - [Model.InputFolderReference](docs/InputFolderReference.md)
 - [Model.InputFolderReferenceAllOf](docs/InputFolderReferenceAllOf.md)
 - [Model.InputPathReference](docs/InputPathReference.md)
 - [Model.InputPathReferenceAllOf](docs/InputPathReferenceAllOf.md)
 - [Model.InputReference](docs/InputReference.md)
 - [Model.InputReferenceAllOf](docs/InputReferenceAllOf.md)
 - [Model.InputReferenceBase](docs/InputReferenceBase.md)
 - [Model.InputReferenceBaseAllOf](docs/InputReferenceBaseAllOf.md)
 - [Model.ItemReference](docs/ItemReference.md)
 - [Model.ItemReferenceAllOf](docs/ItemReferenceAllOf.md)
 - [Model.ItemType](docs/ItemType.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobAllOf](docs/JobAllOf.md)
 - [Model.JobArgument](docs/JobArgument.md)
 - [Model.JobArgumentAllOf](docs/JobArgumentAllOf.md)
 - [Model.JobPathArgument](docs/JobPathArgument.md)
 - [Model.JobPathArgumentAllOf](docs/JobPathArgumentAllOf.md)
 - [Model.JobStatus](docs/JobStatus.md)
 - [Model.JobStatusAllOf](docs/JobStatusAllOf.md)
 - [Model.JobStatusEnum](docs/JobStatusEnum.md)
 - [Model.KeyRequest](docs/KeyRequest.md)
 - [Model.KeyRequestAllOf](docs/KeyRequestAllOf.md)
 - [Model.License](docs/License.md)
 - [Model.LicenseAllOf](docs/LicenseAllOf.md)
 - [Model.ListResponseMeta](docs/ListResponseMeta.md)
 - [Model.ListResponseMetaAllOf](docs/ListResponseMetaAllOf.md)
 - [Model.LocalConfig](docs/LocalConfig.md)
 - [Model.LocalConfigAllOf](docs/LocalConfigAllOf.md)
 - [Model.Maintainer](docs/Maintainer.md)
 - [Model.MaintainerAllOf](docs/MaintainerAllOf.md)
 - [Model.MetaData](docs/MetaData.md)
 - [Model.MetaDataAllOf](docs/MetaDataAllOf.md)
 - [Model.NewPluginPackage](docs/NewPluginPackage.md)
 - [Model.NewPluginPackageAllOf](docs/NewPluginPackageAllOf.md)
 - [Model.NewRecipePackage](docs/NewRecipePackage.md)
 - [Model.NewRecipePackageAllOf](docs/NewRecipePackageAllOf.md)
 - [Model.OpenAPIGenBaseModel](docs/OpenAPIGenBaseModel.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationAllOf](docs/OrganizationAllOf.md)
 - [Model.OrganizationCreate](docs/OrganizationCreate.md)
 - [Model.OrganizationCreateAllOf](docs/OrganizationCreateAllOf.md)
 - [Model.OrganizationList](docs/OrganizationList.md)
 - [Model.OrganizationListAllOf](docs/OrganizationListAllOf.md)
 - [Model.OrganizationMember](docs/OrganizationMember.md)
 - [Model.OrganizationMemberAllOf](docs/OrganizationMemberAllOf.md)
 - [Model.OrganizationMemberList](docs/OrganizationMemberList.md)
 - [Model.OrganizationMemberListAllOf](docs/OrganizationMemberListAllOf.md)
 - [Model.OrganizationRoleEnum](docs/OrganizationRoleEnum.md)
 - [Model.OrganizationUpdate](docs/OrganizationUpdate.md)
 - [Model.OrganizationUpdateAllOf](docs/OrganizationUpdateAllOf.md)
 - [Model.PackageVersion](docs/PackageVersion.md)
 - [Model.PackageVersionAllOf](docs/PackageVersionAllOf.md)
 - [Model.PathOutput](docs/PathOutput.md)
 - [Model.PathOutputAllOf](docs/PathOutputAllOf.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.Plugin](docs/Plugin.md)
 - [Model.PluginAllOf](docs/PluginAllOf.md)
 - [Model.PluginConfig](docs/PluginConfig.md)
 - [Model.PluginConfigAllOf](docs/PluginConfigAllOf.md)
 - [Model.PluginPackage](docs/PluginPackage.md)
 - [Model.PluginPackageAllOf](docs/PluginPackageAllOf.md)
 - [Model.PluginPackageList](docs/PluginPackageList.md)
 - [Model.PluginPackageListAllOf](docs/PluginPackageListAllOf.md)
 - [Model.PolicySubject](docs/PolicySubject.md)
 - [Model.PolicySubjectAllOf](docs/PolicySubjectAllOf.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectAccessPolicy](docs/ProjectAccessPolicy.md)
 - [Model.ProjectAccessPolicyAllOf](docs/ProjectAccessPolicyAllOf.md)
 - [Model.ProjectAccessPolicyList](docs/ProjectAccessPolicyList.md)
 - [Model.ProjectAccessPolicyListAllOf](docs/ProjectAccessPolicyListAllOf.md)
 - [Model.ProjectAllOf](docs/ProjectAllOf.md)
 - [Model.ProjectCreate](docs/ProjectCreate.md)
 - [Model.ProjectCreateAllOf](docs/ProjectCreateAllOf.md)
 - [Model.ProjectFolder](docs/ProjectFolder.md)
 - [Model.ProjectFolderAllOf](docs/ProjectFolderAllOf.md)
 - [Model.ProjectList](docs/ProjectList.md)
 - [Model.ProjectListAllOf](docs/ProjectListAllOf.md)
 - [Model.ProjectPolicySubject](docs/ProjectPolicySubject.md)
 - [Model.ProjectPolicySubjectAllOf](docs/ProjectPolicySubjectAllOf.md)
 - [Model.ProjectRecipeFilter](docs/ProjectRecipeFilter.md)
 - [Model.ProjectRecipeFilterAllOf](docs/ProjectRecipeFilterAllOf.md)
 - [Model.ProjectRecipeFilterList](docs/ProjectRecipeFilterList.md)
 - [Model.ProjectRecipeFilterListAllOf](docs/ProjectRecipeFilterListAllOf.md)
 - [Model.ProjectUpdate](docs/ProjectUpdate.md)
 - [Model.ProjectUpdateAllOf](docs/ProjectUpdateAllOf.md)
 - [Model.PublicAccountList](docs/PublicAccountList.md)
 - [Model.PublicAccountListAllOf](docs/PublicAccountListAllOf.md)
 - [Model.Recipe](docs/Recipe.md)
 - [Model.RecipeAllOf](docs/RecipeAllOf.md)
 - [Model.RecipeInterface](docs/RecipeInterface.md)
 - [Model.RecipeInterfaceAllOf](docs/RecipeInterfaceAllOf.md)
 - [Model.RecipeInterfaceList](docs/RecipeInterfaceList.md)
 - [Model.RecipeInterfaceListAllOf](docs/RecipeInterfaceListAllOf.md)
 - [Model.RecipePackage](docs/RecipePackage.md)
 - [Model.RecipePackageAllOf](docs/RecipePackageAllOf.md)
 - [Model.RecipePackageList](docs/RecipePackageList.md)
 - [Model.RecipePackageListAllOf](docs/RecipePackageListAllOf.md)
 - [Model.Repository](docs/Repository.md)
 - [Model.RepositoryAccessPolicy](docs/RepositoryAccessPolicy.md)
 - [Model.RepositoryAccessPolicyAllOf](docs/RepositoryAccessPolicyAllOf.md)
 - [Model.RepositoryAccessPolicyList](docs/RepositoryAccessPolicyList.md)
 - [Model.RepositoryAccessPolicyListAllOf](docs/RepositoryAccessPolicyListAllOf.md)
 - [Model.RepositoryAllOf](docs/RepositoryAllOf.md)
 - [Model.RepositoryCreate](docs/RepositoryCreate.md)
 - [Model.RepositoryCreateAllOf](docs/RepositoryCreateAllOf.md)
 - [Model.RepositoryIndex](docs/RepositoryIndex.md)
 - [Model.RepositoryIndexAllOf](docs/RepositoryIndexAllOf.md)
 - [Model.RepositoryList](docs/RepositoryList.md)
 - [Model.RepositoryListAllOf](docs/RepositoryListAllOf.md)
 - [Model.RepositoryMetadata](docs/RepositoryMetadata.md)
 - [Model.RepositoryMetadataAllOf](docs/RepositoryMetadataAllOf.md)
 - [Model.RepositoryPackage](docs/RepositoryPackage.md)
 - [Model.RepositoryPackageAllOf](docs/RepositoryPackageAllOf.md)
 - [Model.RepositoryPolicySubject](docs/RepositoryPolicySubject.md)
 - [Model.RepositoryPolicySubjectAllOf](docs/RepositoryPolicySubjectAllOf.md)
 - [Model.RepositoryUpdate](docs/RepositoryUpdate.md)
 - [Model.RepositoryUpdateAllOf](docs/RepositoryUpdateAllOf.md)
 - [Model.RepositoryUserPermissions](docs/RepositoryUserPermissions.md)
 - [Model.RepositoryUserPermissionsAllOf](docs/RepositoryUserPermissionsAllOf.md)
 - [Model.RoleEnum](docs/RoleEnum.md)
 - [Model.Run](docs/Run.md)
 - [Model.RunAllOf](docs/RunAllOf.md)
 - [Model.RunList](docs/RunList.md)
 - [Model.RunListAllOf](docs/RunListAllOf.md)
 - [Model.RunResultList](docs/RunResultList.md)
 - [Model.RunResultListAllOf](docs/RunResultListAllOf.md)
 - [Model.RunStatus](docs/RunStatus.md)
 - [Model.RunStatusAllOf](docs/RunStatusAllOf.md)
 - [Model.RunStatusEnum](docs/RunStatusEnum.md)
 - [Model.S3](docs/S3.md)
 - [Model.S3AllOf](docs/S3AllOf.md)
 - [Model.S3UploadRequest](docs/S3UploadRequest.md)
 - [Model.S3UploadRequestAllOf](docs/S3UploadRequestAllOf.md)
 - [Model.SortEnum](docs/SortEnum.md)
 - [Model.StatusType](docs/StatusType.md)
 - [Model.StepArrayInput](docs/StepArrayInput.md)
 - [Model.StepArrayInputAllOf](docs/StepArrayInputAllOf.md)
 - [Model.StepArrayOutput](docs/StepArrayOutput.md)
 - [Model.StepArrayOutputAllOf](docs/StepArrayOutputAllOf.md)
 - [Model.StepBooleanInput](docs/StepBooleanInput.md)
 - [Model.StepBooleanInputAllOf](docs/StepBooleanInputAllOf.md)
 - [Model.StepBooleanOutput](docs/StepBooleanOutput.md)
 - [Model.StepBooleanOutputAllOf](docs/StepBooleanOutputAllOf.md)
 - [Model.StepFileInput](docs/StepFileInput.md)
 - [Model.StepFileInputAllOf](docs/StepFileInputAllOf.md)
 - [Model.StepFileOutput](docs/StepFileOutput.md)
 - [Model.StepFileOutputAllOf](docs/StepFileOutputAllOf.md)
 - [Model.StepFolderInput](docs/StepFolderInput.md)
 - [Model.StepFolderInputAllOf](docs/StepFolderInputAllOf.md)
 - [Model.StepFolderOutput](docs/StepFolderOutput.md)
 - [Model.StepFolderOutputAllOf](docs/StepFolderOutputAllOf.md)
 - [Model.StepIntegerInput](docs/StepIntegerInput.md)
 - [Model.StepIntegerInputAllOf](docs/StepIntegerInputAllOf.md)
 - [Model.StepIntegerOutput](docs/StepIntegerOutput.md)
 - [Model.StepIntegerOutputAllOf](docs/StepIntegerOutputAllOf.md)
 - [Model.StepJSONObjectInput](docs/StepJSONObjectInput.md)
 - [Model.StepJSONObjectInputAllOf](docs/StepJSONObjectInputAllOf.md)
 - [Model.StepJSONObjectOutput](docs/StepJSONObjectOutput.md)
 - [Model.StepJSONObjectOutputAllOf](docs/StepJSONObjectOutputAllOf.md)
 - [Model.StepList](docs/StepList.md)
 - [Model.StepListAllOf](docs/StepListAllOf.md)
 - [Model.StepNumberInput](docs/StepNumberInput.md)
 - [Model.StepNumberInputAllOf](docs/StepNumberInputAllOf.md)
 - [Model.StepNumberOutput](docs/StepNumberOutput.md)
 - [Model.StepNumberOutputAllOf](docs/StepNumberOutputAllOf.md)
 - [Model.StepPathInput](docs/StepPathInput.md)
 - [Model.StepPathInputAllOf](docs/StepPathInputAllOf.md)
 - [Model.StepPathOutput](docs/StepPathOutput.md)
 - [Model.StepPathOutputAllOf](docs/StepPathOutputAllOf.md)
 - [Model.StepStatus](docs/StepStatus.md)
 - [Model.StepStatusAllOf](docs/StepStatusAllOf.md)
 - [Model.StepStatusEnum](docs/StepStatusEnum.md)
 - [Model.StepStringInput](docs/StepStringInput.md)
 - [Model.StepStringInputAllOf](docs/StepStringInputAllOf.md)
 - [Model.StepStringOutput](docs/StepStringOutput.md)
 - [Model.StepStringOutputAllOf](docs/StepStringOutputAllOf.md)
 - [Model.SubjectType](docs/SubjectType.md)
 - [Model.TaskArgument](docs/TaskArgument.md)
 - [Model.TaskArgumentAllOf](docs/TaskArgumentAllOf.md)
 - [Model.TaskFileReference](docs/TaskFileReference.md)
 - [Model.TaskFileReferenceAllOf](docs/TaskFileReferenceAllOf.md)
 - [Model.TaskFolderReference](docs/TaskFolderReference.md)
 - [Model.TaskFolderReferenceAllOf](docs/TaskFolderReferenceAllOf.md)
 - [Model.TaskPathArgument](docs/TaskPathArgument.md)
 - [Model.TaskPathArgumentAllOf](docs/TaskPathArgumentAllOf.md)
 - [Model.TaskPathReference](docs/TaskPathReference.md)
 - [Model.TaskPathReferenceAllOf](docs/TaskPathReferenceAllOf.md)
 - [Model.TaskPathReturn](docs/TaskPathReturn.md)
 - [Model.TaskPathReturnAllOf](docs/TaskPathReturnAllOf.md)
 - [Model.TaskReference](docs/TaskReference.md)
 - [Model.TaskReferenceAllOf](docs/TaskReferenceAllOf.md)
 - [Model.TaskReferenceBase](docs/TaskReferenceBase.md)
 - [Model.TaskReferenceBaseAllOf](docs/TaskReferenceBaseAllOf.md)
 - [Model.TaskReturn](docs/TaskReturn.md)
 - [Model.TaskReturnAllOf](docs/TaskReturnAllOf.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamAllOf](docs/TeamAllOf.md)
 - [Model.TeamCreate](docs/TeamCreate.md)
 - [Model.TeamCreateAllOf](docs/TeamCreateAllOf.md)
 - [Model.TeamList](docs/TeamList.md)
 - [Model.TeamListAllOf](docs/TeamListAllOf.md)
 - [Model.TeamMember](docs/TeamMember.md)
 - [Model.TeamMemberAllOf](docs/TeamMemberAllOf.md)
 - [Model.TeamMemberList](docs/TeamMemberList.md)
 - [Model.TeamMemberListAllOf](docs/TeamMemberListAllOf.md)
 - [Model.TeamRoleEnum](docs/TeamRoleEnum.md)
 - [Model.TeamUpdate](docs/TeamUpdate.md)
 - [Model.TeamUpdateAllOf](docs/TeamUpdateAllOf.md)
 - [Model.UpdateAccepted](docs/UpdateAccepted.md)
 - [Model.UpdateAcceptedAllOf](docs/UpdateAcceptedAllOf.md)
 - [Model.Usage](docs/Usage.md)
 - [Model.UsageAllOf](docs/UsageAllOf.md)
 - [Model.UserCreate](docs/UserCreate.md)
 - [Model.UserCreateAllOf](docs/UserCreateAllOf.md)
 - [Model.UserPermission](docs/UserPermission.md)
 - [Model.UserPermissionAllOf](docs/UserPermissionAllOf.md)
 - [Model.UserPrivate](docs/UserPrivate.md)
 - [Model.UserPrivateAllOf](docs/UserPrivateAllOf.md)
 - [Model.UserPublic](docs/UserPublic.md)
 - [Model.UserPublicAllOf](docs/UserPublicAllOf.md)
 - [Model.UserPublicList](docs/UserPublicList.md)
 - [Model.UserPublicListAllOf](docs/UserPublicListAllOf.md)
 - [Model.UserUpdate](docs/UserUpdate.md)
 - [Model.UserUpdateAllOf](docs/UserUpdateAllOf.md)
 - [Model.ValueFileReference](docs/ValueFileReference.md)
 - [Model.ValueFileReferenceAllOf](docs/ValueFileReferenceAllOf.md)
 - [Model.ValueFolderReference](docs/ValueFolderReference.md)
 - [Model.ValueFolderReferenceAllOf](docs/ValueFolderReferenceAllOf.md)
 - [Model.ValueListReference](docs/ValueListReference.md)
 - [Model.ValueListReferenceAllOf](docs/ValueListReferenceAllOf.md)
 - [Model.ValueReference](docs/ValueReference.md)
 - [Model.ValueReferenceAllOf](docs/ValueReferenceAllOf.md)


## Documentation for Authorization


### APIKeyAuth

- **Type**: API key

- **API key parameter name**: x-pollination-token
- **Location**: HTTP header


### JWTAuth


- **Type**: HTTP bearer authentication

