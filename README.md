[![Build](https://github.com/ladybug-tools/honeybee-schema-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/honeybee-schema-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/PollinationSDK?dWidth=50)](https://www.nuget.org/packages/PollinationSDK)
# PollinationSDK - the C# library for the Pollination Server

Pollination Server OpenAPI Defintion

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.0
- SDK version: 0.8.8
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://pollination.cloud](https://pollination.cloud)

## Frameworks supported


- .NET 4.5 or later

## Dependencies


- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
```


## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using PollinationSDK;

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
using PollinationSDK;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.pollination.cloud";
            var apiInstance = new AccountsApi(Configuration.Default);
            var name = name_example;  // string | 

            try
            {
                // Get an account by name
                AccountPublic result = apiInstance.GetAccount(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.pollination.cloud*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**GetAccount**](docs/AccountsApi.md#getaccount) | **GET** /accounts/{name} | Get an account by name
*AccountsApi* | [**ListAccounts**](docs/AccountsApi.md#listaccounts) | **GET** /accounts | List Accounts on the Pollination platform
*ArtifactsApi* | [**CreateArtifact**](docs/ArtifactsApi.md#createartifact) | **POST** /projects/{owner}/{name}/artifacts | Get an Artifact upload link.
*ArtifactsApi* | [**DeleteArtifact**](docs/ArtifactsApi.md#deleteartifact) | **DELETE** /projects/{owner}/{name}/artifacts | Delete one or many artifacts by key/prefix
*ArtifactsApi* | [**DownloadArtifact**](docs/ArtifactsApi.md#downloadartifact) | **GET** /projects/{owner}/{name}/artifacts/download | Download an artifact from the project folder
*ArtifactsApi* | [**ListArtifacts**](docs/ArtifactsApi.md#listartifacts) | **GET** /projects/{owner}/{name}/artifacts | List artifacts in a project folder
*OperatorsApi* | [**CreateOperator**](docs/OperatorsApi.md#createoperator) | **POST** /operators/{owner} | Create an Operator
*OperatorsApi* | [**CreateOperatorPackage**](docs/OperatorsApi.md#createoperatorpackage) | **POST** /operators/{owner}/{name}/tags | Create a new Operator package
*OperatorsApi* | [**DeleteOperator**](docs/OperatorsApi.md#deleteoperator) | **DELETE** /operators/{owner}/{name} | Delete an Operator
*OperatorsApi* | [**DeleteOperatorOrgPermission**](docs/OperatorsApi.md#deleteoperatororgpermission) | **DELETE** /operators/{owner}/{name}/permissions | Remove a Repository permissions
*OperatorsApi* | [**GetOperator**](docs/OperatorsApi.md#getoperator) | **GET** /operators/{owner}/{name} | Get an operator
*OperatorsApi* | [**GetOperatorAccessPermissions**](docs/OperatorsApi.md#getoperatoraccesspermissions) | **GET** /operators/{owner}/{name}/permissions | Get operator access permissions
*OperatorsApi* | [**GetOperatorByTag**](docs/OperatorsApi.md#getoperatorbytag) | **GET** /operators/{owner}/{name}/tags/{tag} | Get an operator tag
*OperatorsApi* | [**ListOperatorTags**](docs/OperatorsApi.md#listoperatortags) | **GET** /operators/{owner}/{name}/tags | Get an operator tags
*OperatorsApi* | [**ListOperators**](docs/OperatorsApi.md#listoperators) | **GET** /operators | List operators
*OperatorsApi* | [**UpdateOperator**](docs/OperatorsApi.md#updateoperator) | **PUT** /operators/{owner}/{name} | Update an Operator
*OperatorsApi* | [**UpsertOperatorPermission**](docs/OperatorsApi.md#upsertoperatorpermission) | **PATCH** /operators/{owner}/{name}/permissions | Upsert a new permission to a operator
*OrgsApi* | [**CreateOrg**](docs/OrgsApi.md#createorg) | **POST** /orgs | Create an Org
*OrgsApi* | [**DeleteOrg**](docs/OrgsApi.md#deleteorg) | **DELETE** /orgs/{name} | Delete an Org
*OrgsApi* | [**DeleteOrgMember**](docs/OrgsApi.md#deleteorgmember) | **DELETE** /orgs/{name}/members/{username} | Remove an Org member
*OrgsApi* | [**GetOrg**](docs/OrgsApi.md#getorg) | **GET** /orgs/{name} | Get an Org
*OrgsApi* | [**GetOrgMembers**](docs/OrgsApi.md#getorgmembers) | **GET** /orgs/{name}/members | List organization members
*OrgsApi* | [**ListOrgs**](docs/OrgsApi.md#listorgs) | **GET** /orgs | List Orgs
*OrgsApi* | [**UpdateOrg**](docs/OrgsApi.md#updateorg) | **PUT** /orgs/{name} | Update an Org
*OrgsApi* | [**UpsertOrgMember**](docs/OrgsApi.md#upsertorgmember) | **PATCH** /orgs/{name}/members/{username}/{role} | Add or update the role of an Org Member
*ProjectsApi* | [**CreateProject**](docs/ProjectsApi.md#createproject) | **POST** /projects/{owner} | Create a Project
*ProjectsApi* | [**CreateProjectRecipeFilter**](docs/ProjectsApi.md#createprojectrecipefilter) | **POST** /projects/{owner}/{name}/recipes/filters | Upsert a recipe filter to a project
*ProjectsApi* | [**DeleteProject**](docs/ProjectsApi.md#deleteproject) | **DELETE** /projects/{owner}/{name} | Delete a Project
*ProjectsApi* | [**DeleteProjectOrgPermission**](docs/ProjectsApi.md#deleteprojectorgpermission) | **DELETE** /projects/{owner}/{name}/permissions | Remove a Project permissions
*ProjectsApi* | [**DeleteProjectRecipeFilter**](docs/ProjectsApi.md#deleteprojectrecipefilter) | **DELETE** /projects/{owner}/{name}/recipes/filters | Remove a Project permissions
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
*RegistriesApi* | [**GetRegistryIndex**](docs/RegistriesApi.md#getregistryindex) | **GET** /registries/{owner}/index.json | Get Registry Index
*RegistriesApi* | [**PostOperator**](docs/RegistriesApi.md#postoperator) | **POST** /registries/{owner}/operators | Push an Operator to the registry
*RegistriesApi* | [**PostRecipe**](docs/RegistriesApi.md#postrecipe) | **POST** /registries/{owner}/recipes | Push an Recipe to the registry
*SimulationsApi* | [**CreateSimulation**](docs/SimulationsApi.md#createsimulation) | **POST** /projects/{owner}/{name}/simulations | Schedule a simulation
*SimulationsApi* | [**DownloadSimulationArtifact**](docs/SimulationsApi.md#downloadsimulationartifact) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/artifacts/download | Download an artifact from the simulation folder
*SimulationsApi* | [**GetSimulation**](docs/SimulationsApi.md#getsimulation) | **GET** /projects/{owner}/{name}/simulations/{simulation_id} | Get a Simulation
*SimulationsApi* | [**GetSimulationInputs**](docs/SimulationsApi.md#getsimulationinputs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/inputs | Get simulation inputs
*SimulationsApi* | [**GetSimulationLogs**](docs/SimulationsApi.md#getsimulationlogs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/logs | Get simulation logs
*SimulationsApi* | [**GetSimulationOutputArtifact**](docs/SimulationsApi.md#getsimulationoutputartifact) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/outputs/artifacts/{artifact_name} | Get simulation output artifact by name
*SimulationsApi* | [**GetSimulationOutputs**](docs/SimulationsApi.md#getsimulationoutputs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/outputs | Get simulation outputs
*SimulationsApi* | [**GetSimulationTaskLogs**](docs/SimulationsApi.md#getsimulationtasklogs) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/task/{task_id}/logs | Get simulation logs
*SimulationsApi* | [**ListSimulationArtifacts**](docs/SimulationsApi.md#listsimulationartifacts) | **GET** /projects/{owner}/{name}/simulations/{simulation_id}/artifacts | List artifacts in a simulation folder
*SimulationsApi* | [**ListSimulations**](docs/SimulationsApi.md#listsimulations) | **GET** /projects/{owner}/{name}/simulations | List simulations
*SimulationsApi* | [**ResumeSimulation**](docs/SimulationsApi.md#resumesimulation) | **PUT** /projects/{owner}/{name}/simulations/{simulation_id}/resume | resume a simulation
*SimulationsApi* | [**StopSimulation**](docs/SimulationsApi.md#stopsimulation) | **PUT** /projects/{owner}/{name}/simulations/{simulation_id}/stop | Stop a simulation
*SimulationsApi* | [**SuspendSimulation**](docs/SimulationsApi.md#suspendsimulation) | **PUT** /projects/{owner}/{name}/simulations/{simulation_id}/suspend | Suspend a simulation
*TeamsApi* | [**CreateTeam**](docs/TeamsApi.md#createteam) | **POST** /orgs/{org_name}/teams | Create a Team
*TeamsApi* | [**DeleteOrgTeamMember**](docs/TeamsApi.md#deleteorgteammember) | **DELETE** /orgs/{org_name}/teams/{team_slug}/members/{username} | Remove a team member
*TeamsApi* | [**DeleteTeam**](docs/TeamsApi.md#deleteteam) | **DELETE** /orgs/{org_name}/teams/{team_slug} | Delete a Team
*TeamsApi* | [**GetOrgTeamMembers**](docs/TeamsApi.md#getorgteammembers) | **GET** /orgs/{org_name}/teams/{team_slug}/members | List team members
*TeamsApi* | [**GetTeam**](docs/TeamsApi.md#getteam) | **GET** /orgs/{org_name}/teams/{team_slug} | Get a Team
*TeamsApi* | [**ListOrgTeams**](docs/TeamsApi.md#listorgteams) | **GET** /orgs/{org_name}/teams | List Teams
*TeamsApi* | [**UpdateTeam**](docs/TeamsApi.md#updateteam) | **PUT** /orgs/{org_name}/teams/{team_slug} | Update a Team
*TeamsApi* | [**UpsertOrgTeamMember**](docs/TeamsApi.md#upsertorgteammember) | **PATCH** /orgs/{org_name}/teams/{team_slug}/members/{username}/{role} | Add or update the role of an Team Member
*UserApi* | [**ChangePassword**](docs/UserApi.md#changepassword) | **POST** /user/change_password | Make a password change request
*UserApi* | [**GetMe**](docs/UserApi.md#getme) | **GET** /user | Get authenticated user profile.
*UserApi* | [**GetRoles**](docs/UserApi.md#getroles) | **GET** /user/roles | Get the authenticated user roles
*UserApi* | [**ListRefreshTokens**](docs/UserApi.md#listrefreshtokens) | **GET** /user/tokens | Get a list of token names
*UserApi* | [**Login**](docs/UserApi.md#login) | **POST** /user/login | Login to the platform and get a JWT back
*UserApi* | [**Signup**](docs/UserApi.md#signup) | **POST** /user/signup | Sign Up to the platform!
*UserApi* | [**UpsertRefreshToken**](docs/UserApi.md#upsertrefreshtoken) | **POST** /user/tokens | Get refresh token and delete previous one if it exists
*UsersApi* | [**CheckUsername**](docs/UsersApi.md#checkusername) | **GET** /users/check_username/{username} | Check if a username is already taken
*UsersApi* | [**GetOneUser**](docs/UsersApi.md#getoneuser) | **GET** /users/{name} | Get a specific user profile
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /users | List Users


## Documentation for Models

 - [Model.Accepted](docs/Accepted.md)
 - [Model.AccountPublic](docs/AccountPublic.md)
 - [Model.ArgumentArtifact](docs/ArgumentArtifact.md)
 - [Model.ArgumentParameter](docs/ArgumentParameter.md)
 - [Model.Arguments](docs/Arguments.md)
 - [Model.BodyPostOperatorRegistriesOwnerOperatorsPost](docs/BodyPostOperatorRegistriesOwnerOperatorsPost.md)
 - [Model.BodyPostRecipeRegistriesOwnerRecipesPost](docs/BodyPostRecipeRegistriesOwnerRecipesPost.md)
 - [Model.Config](docs/Config.md)
 - [Model.CreatedContent](docs/CreatedContent.md)
 - [Model.DAG](docs/DAG.md)
 - [Model.DAGInputArtifact](docs/DAGInputArtifact.md)
 - [Model.DAGInputParameter](docs/DAGInputParameter.md)
 - [Model.DAGInputs](docs/DAGInputs.md)
 - [Model.DAGOutputArtifact](docs/DAGOutputArtifact.md)
 - [Model.DAGOutputParameter](docs/DAGOutputParameter.md)
 - [Model.DAGOutputs](docs/DAGOutputs.md)
 - [Model.DAGTask](docs/DAGTask.md)
 - [Model.DAGTaskArgument](docs/DAGTaskArgument.md)
 - [Model.DAGTaskArtifactArgument](docs/DAGTaskArtifactArgument.md)
 - [Model.DAGTaskLoop](docs/DAGTaskLoop.md)
 - [Model.DAGTaskOutputArtifact](docs/DAGTaskOutputArtifact.md)
 - [Model.DAGTaskOutputParameter](docs/DAGTaskOutputParameter.md)
 - [Model.DAGTaskOutputs](docs/DAGTaskOutputs.md)
 - [Model.DAGTaskParameterArgument](docs/DAGTaskParameterArgument.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.DependencyType](docs/DependencyType.md)
 - [Model.DockerConfig](docs/DockerConfig.md)
 - [Model.EmailRequest](docs/EmailRequest.md)
 - [Model.FileMeta](docs/FileMeta.md)
 - [Model.FolderArtifactReference](docs/FolderArtifactReference.md)
 - [Model.FolderReference](docs/FolderReference.md)
 - [Model.Function](docs/Function.md)
 - [Model.FunctionArtifact](docs/FunctionArtifact.md)
 - [Model.FunctionInputs](docs/FunctionInputs.md)
 - [Model.FunctionOutputs](docs/FunctionOutputs.md)
 - [Model.FunctionParameterIn](docs/FunctionParameterIn.md)
 - [Model.FunctionParameterOut](docs/FunctionParameterOut.md)
 - [Model.HTTPSource](docs/HTTPSource.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.InputArtifactReference](docs/InputArtifactReference.md)
 - [Model.InputParameterReference](docs/InputParameterReference.md)
 - [Model.InputReference](docs/InputReference.md)
 - [Model.ItemParameterReference](docs/ItemParameterReference.md)
 - [Model.ItemReference](docs/ItemReference.md)
 - [Model.KeyRequest](docs/KeyRequest.md)
 - [Model.License](docs/License.md)
 - [Model.Login](docs/Login.md)
 - [Model.LoginToken](docs/LoginToken.md)
 - [Model.Maintainer](docs/Maintainer.md)
 - [Model.MetaData](docs/MetaData.md)
 - [Model.NewOperatorPackage](docs/NewOperatorPackage.md)
 - [Model.NewRecipePackage](docs/NewRecipePackage.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.OperatorPackage](docs/OperatorPackage.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationCreate](docs/OrganizationCreate.md)
 - [Model.OrganizationList](docs/OrganizationList.md)
 - [Model.OrganizationMember](docs/OrganizationMember.md)
 - [Model.OrganizationMemberList](docs/OrganizationMemberList.md)
 - [Model.OrganizationRoleEnum](docs/OrganizationRoleEnum.md)
 - [Model.OrganizationUpdate](docs/OrganizationUpdate.md)
 - [Model.PackageVersion](docs/PackageVersion.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.PolicySubject](docs/PolicySubject.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectAccessPolicy](docs/ProjectAccessPolicy.md)
 - [Model.ProjectAccessPolicyList](docs/ProjectAccessPolicyList.md)
 - [Model.ProjectCreate](docs/ProjectCreate.md)
 - [Model.ProjectFolderSource](docs/ProjectFolderSource.md)
 - [Model.ProjectList](docs/ProjectList.md)
 - [Model.ProjectPolicySubject](docs/ProjectPolicySubject.md)
 - [Model.ProjectRecipeFilter](docs/ProjectRecipeFilter.md)
 - [Model.ProjectRecipeFilterList](docs/ProjectRecipeFilterList.md)
 - [Model.ProjectUpdate](docs/ProjectUpdate.md)
 - [Model.ProjectUserPermissions](docs/ProjectUserPermissions.md)
 - [Model.PublicAccountList](docs/PublicAccountList.md)
 - [Model.Recipe](docs/Recipe.md)
 - [Model.RecipePackage](docs/RecipePackage.md)
 - [Model.RecipeSelection](docs/RecipeSelection.md)
 - [Model.RefreshToken](docs/RefreshToken.md)
 - [Model.RefreshTokenCreate](docs/RefreshTokenCreate.md)
 - [Model.Repository](docs/Repository.md)
 - [Model.RepositoryAccessPolicy](docs/RepositoryAccessPolicy.md)
 - [Model.RepositoryAccessPolicyList](docs/RepositoryAccessPolicyList.md)
 - [Model.RepositoryCreate](docs/RepositoryCreate.md)
 - [Model.RepositoryIndex](docs/RepositoryIndex.md)
 - [Model.RepositoryList](docs/RepositoryList.md)
 - [Model.RepositoryMetadata](docs/RepositoryMetadata.md)
 - [Model.RepositoryPackageAbriged](docs/RepositoryPackageAbriged.md)
 - [Model.RepositoryPackageList](docs/RepositoryPackageList.md)
 - [Model.RepositoryPolicySubject](docs/RepositoryPolicySubject.md)
 - [Model.RepositoryUpdate](docs/RepositoryUpdate.md)
 - [Model.RepositoryUserPermissions](docs/RepositoryUserPermissions.md)
 - [Model.S3Source](docs/S3Source.md)
 - [Model.S3UploadRequest](docs/S3UploadRequest.md)
 - [Model.SignUp](docs/SignUp.md)
 - [Model.SimulationInputArtifact](docs/SimulationInputArtifact.md)
 - [Model.SimulationInputs](docs/SimulationInputs.md)
 - [Model.SimulationList](docs/SimulationList.md)
 - [Model.SimulationOutputSource](docs/SimulationOutputSource.md)
 - [Model.SimulationStatus](docs/SimulationStatus.md)
 - [Model.StatusType](docs/StatusType.md)
 - [Model.SubjectType](docs/SubjectType.md)
 - [Model.SubmitSimulation](docs/SubmitSimulation.md)
 - [Model.TaskArtifactReference](docs/TaskArtifactReference.md)
 - [Model.TaskParameterReference](docs/TaskParameterReference.md)
 - [Model.TaskReference](docs/TaskReference.md)
 - [Model.TaskStatus](docs/TaskStatus.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamCreate](docs/TeamCreate.md)
 - [Model.TeamList](docs/TeamList.md)
 - [Model.TeamMember](docs/TeamMember.md)
 - [Model.TeamMemberList](docs/TeamMemberList.md)
 - [Model.TeamRoleEnum](docs/TeamRoleEnum.md)
 - [Model.TeamUpdate](docs/TeamUpdate.md)
 - [Model.UpdateAccepted](docs/UpdateAccepted.md)
 - [Model.UserMetadata](docs/UserMetadata.md)
 - [Model.UserPrivate](docs/UserPrivate.md)
 - [Model.UserPublic](docs/UserPublic.md)
 - [Model.UserPublicList](docs/UserPublicList.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.WorkflowStatus](docs/WorkflowStatus.md)


## Documentation for Authorization


### CompulsoryAuth


- **Type**: HTTP basic authentication


### JWT


- **Type**: HTTP basic authentication


### OptionalAuth


- **Type**: HTTP basic authentication

