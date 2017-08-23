using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    public class PermissionApiTest
    {
        private string basePath = "http://localhost:5000";
        private PermissionApi permissionTest = new PermissionApi("http://localhost:5000");
        private Configuration configuration;

        [Fact]
        public void OnCreate()
        {
            permissionTest = new PermissionApi(this.basePath);
            
            Assert.NotNull(permissionTest.Configuration);
        }

        [Fact]
        public void OnCreateWhithOutBasePath()
        {
            permissionTest = new PermissionApi();

            Assert.NotNull(permissionTest.Configuration);
        }

        [Fact]
        public void ApiV1PermissionCreateAndDeletePost()
        {
            configuration = GetClientConfig();
            permissionTest = new PermissionApi(configuration);
            RepositorySecurityContext addPermissionRequest = new RepositorySecurityContext();
            ItemTypePermission permission = new ItemTypePermission
            {
                ItemType = Guid.NewGuid(),
                Permission = ItemTypePermission.PermissionEnum.DeniedWrite,
                RoleName = "Can't Write"
            };
            addPermissionRequest.TypePermissions = new List<ItemTypePermission>
            {
                new ItemTypePermission(01L, "Can't Write", ItemTypePermission.PermissionEnum.DeniedWrite),
                permission
            };

            ApiResponse<object> responsePost = permissionTest.ApiV1PermissionPostWithHttpInfo(addPermissionRequest);
            //GET PermissionTest
            GetPermissionsRequest requestGet = new GetPermissionsRequest
            {
                ItemTypes = new List<Guid?>
            {
                permission.ItemType
            }
            };


            List<long?> idDelete = new List<long?>
            {
                1L
            };
            RemovePermissionsRequest requestDelete = new RemovePermissionsRequest(idDelete);
            ApiResponse<object> response = permissionTest.ApiV1PermissionDeletePostWithHttpInfo(requestDelete);


            Assert.Equal(200, response.StatusCode);
            Assert.Equal(200, responsePost.StatusCode);
        }
        [Fact]
        public void ApiV1PermissionGetPostWithHttpInfoTest()
        {
            configuration = GetClientConfig();
            permissionTest = new PermissionApi(configuration);
            GetPermissionsRequest getPermissionRequest = new GetPermissionsRequest
            {
                Identifiers = new List<IdentifierInRequest>()
            };
            List<Guid?> ids = new List<Guid?>
            {
                new Guid("F87C28F3-32FF-4FAE-B44E-CEDBA4E81FEA")
            };
            getPermissionRequest.ItemTypes = ids;

            ApiResponse<RepositorySecurityContext> response = permissionTest.ApiV1PermissionGetPostWithHttpInfo(getPermissionRequest);
            Console.WriteLine(response.Data.ToJson());
            Assert.Single(response.Data.TypePermissions);
            Assert.Equal(200, response.StatusCode);
        }

        /// <summary>  
        ///  This method return and test a kind of Client Configuration for calling the API.
        /// </summary>
        [Fact]
        public Configuration GetClientConfig()
        {
            ConfigTest configTest = new ConfigTest();
            var client = new ApiClient("http://localhost:5000");

            var configuration = new Configuration(client);
            configuration.ApiKey.Add(configTest.ApiKeyPrefix, configTest.ApiKey);
            configuration.AddDefaultHeader(configTest.ApiKeyPrefix, configTest.ApiKey);
            Assert.NotNull(configuration);
            return configuration;

        }


    }
}
