using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    public class VersionNumberApiTest
    {
        private string basePath = "http://localhost:5000";
        private Configuration configuration;
        private VersionNumberApi versionNumberApiTest;

        [Fact]
        public void OnCreate()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(this.basePath);
            Assert.NotNull(versionNumberApiTest.Configuration);
        }

        [Fact]
        public void OnCreateWithoutPath()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi();
            Assert.NotNull(versionNumberApiTest.Configuration);
        }

        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            Assert.NotNull(versionNumberApiTest.Configuration);
        }

        //[Fact]
        //public void ApiV1ItemByAgencyByIdByTagVersionsLatestGetTest()
        //{
        //    configuration = GetClientConfig();
        //    versionNumberApiTest = new VersionNumberApi(configuration);
        //    ApiResponse<List<IdentifierTriple>> response = versionNumberApiTest.ApiV1ItemByAgencyByIdVersionsGetWithHttpInfo("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
        //    Assert.Equal(500,response.StatusCode);
        //}



        //[Fact]
        //public void ApiV1ItemByAgencyByIdByTagVersionsLatestGetWithHttpInfo()
        //{
        //    configuration = GetClientConfig();
        //    versionNumberApiTest = new VersionNumberApi(configuration);
        //    ApiResponse<long?> response = versionNumberApiTest.ApiV1ItemByAgencyByIdByTagVersionsLatestGetWithHttpInfo("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), "");
        //    Assert.NotNull(response.Data);
        //    Assert.Equal(200, response.StatusCode);
        //}

        [Fact]
        public void ApiV1ItemByAgencyByIdVersionsGetTest()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            List<IdentifierTriple> idsResults = versionNumberApiTest.ApiV1ItemByAgencyByIdVersionsGet("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Single(idsResults);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdVersionsGetWithHttpInfoTest()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            ApiResponse<List<IdentifierTriple>> idsResults = versionNumberApiTest.ApiV1ItemByAgencyByIdVersionsGetWithHttpInfo("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Equal(200, idsResults.StatusCode);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdVersionsLatestGetTest()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            long? id = versionNumberApiTest.ApiV1ItemByAgencyByIdVersionsLatestGet("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Equal(1, id);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdVersionsLatestGetWithHttpInfoTest()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            ApiResponse<long?> infoResponse = versionNumberApiTest.ApiV1ItemByAgencyByIdVersionsLatestGetWithHttpInfo("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Equal(200, infoResponse.StatusCode);
        }

        [Fact]
        public void ApiV1ItemGetLatestVersionNumbersPostTest()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            List<IdentifierInRequest> identifiers = new List<IdentifierInRequest>();
            IdentifierInRequest identifier = new IdentifierInRequest("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L);
            identifiers.Add(identifier);
            GetLatestVersionNumbersRequest request = new GetLatestVersionNumbersRequest(identifiers);
            List<IdentifierTriple> identifiersTriple = versionNumberApiTest.ApiV1ItemGetLatestVersionNumbersPost(request);
            Assert.Single(identifiersTriple);

        }

        [Fact]
        public void ApiV1ItemGetLatestVersionNumbersPostWithHttpInfo()
        {
            configuration = GetClientConfig();
            versionNumberApiTest = new VersionNumberApi(configuration);
            List<IdentifierInRequest> identifiers = new List<IdentifierInRequest>();
            IdentifierInRequest identifier = new IdentifierInRequest("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L);
            identifiers.Add(identifier);
            GetLatestVersionNumbersRequest request = new GetLatestVersionNumbersRequest(identifiers);
            ApiResponse<List<IdentifierTriple>> infos = versionNumberApiTest.ApiV1ItemGetLatestVersionNumbersPostWithHttpInfo(request);
            Assert.Equal(200, infos.StatusCode);
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
