/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using PollinationSDK.Client;
using PollinationSDK.Api;
using PollinationSDK.Model;

namespace PollinationSDK.Test
{
    /// <summary>
    ///  Class for testing RecipesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecipesApiTests
    {
        private RecipesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecipesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecipesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RecipesApi
            //Assert.IsInstanceOf(typeof(RecipesApi), instance);
        }

        
        /// <summary>
        /// Test CreateRecipe
        /// </summary>
        [Test]
        public void CreateRecipeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //RepositoryCreate repositoryCreate = null;
            //var response = instance.CreateRecipe(owner, repositoryCreate);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test CreateRecipePackage
        /// </summary>
        [Test]
        public void CreateRecipePackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //NewRecipePackage newRecipePackage = null;
            //string authorization = null;
            //var response = instance.CreateRecipePackage(owner, name, newRecipePackage, authorization);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test DeleteRecipe
        /// </summary>
        [Test]
        public void DeleteRecipeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //instance.DeleteRecipe(owner, name);
            
        }
        
        /// <summary>
        /// Test DeleteRecipeOrgPermission
        /// </summary>
        [Test]
        public void DeleteRecipeOrgPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryPolicySubject repositoryPolicySubject = null;
            //instance.DeleteRecipeOrgPermission(owner, name, repositoryPolicySubject);
            
        }
        
        /// <summary>
        /// Test GetRecipe
        /// </summary>
        [Test]
        public void GetRecipeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.GetRecipe(owner, name);
            //Assert.IsInstanceOf(typeof(Repository), response, "response is Repository");
        }
        
        /// <summary>
        /// Test GetRecipeAccessPermissions
        /// </summary>
        [Test]
        public void GetRecipeAccessPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //int page = null;
            //int perPage = null;
            //List<string> subjectType = null;
            //List<string> permission = null;
            //var response = instance.GetRecipeAccessPermissions(owner, name, page, perPage, subjectType, permission);
            //Assert.IsInstanceOf(typeof(RepositoryAccessPolicyList), response, "response is RepositoryAccessPolicyList");
        }
        
        /// <summary>
        /// Test GetRecipeByTag
        /// </summary>
        [Test]
        public void GetRecipeByTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //string tag = null;
            //var response = instance.GetRecipeByTag(owner, name, tag);
            //Assert.IsInstanceOf(typeof(RecipePackage), response, "response is RecipePackage");
        }
        
        /// <summary>
        /// Test ListRecipeTags
        /// </summary>
        [Test]
        public void ListRecipeTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.ListRecipeTags(owner, name);
            //Assert.IsInstanceOf(typeof(RepositoryPackageList), response, "response is RepositoryPackageList");
        }
        
        /// <summary>
        /// Test ListRecipes
        /// </summary>
        [Test]
        public void ListRecipesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int page = null;
            //int perPage = null;
            //List<string> name = null;
            //List<string> owner = null;
            //bool _public = null;
            //List<string> keyword = null;
            //List<string> permission = null;
            //var response = instance.ListRecipes(page, perPage, name, owner, _public, keyword, permission);
            //Assert.IsInstanceOf(typeof(RepositoryList), response, "response is RepositoryList");
        }
        
        /// <summary>
        /// Test UpdateRecipe
        /// </summary>
        [Test]
        public void UpdateRecipeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryUpdate repositoryUpdate = null;
            //var response = instance.UpdateRecipe(owner, name, repositoryUpdate);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
        /// <summary>
        /// Test UpsertRecipePermission
        /// </summary>
        [Test]
        public void UpsertRecipePermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryAccessPolicy repositoryAccessPolicy = null;
            //var response = instance.UpsertRecipePermission(owner, name, repositoryAccessPolicy);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
    }

}
