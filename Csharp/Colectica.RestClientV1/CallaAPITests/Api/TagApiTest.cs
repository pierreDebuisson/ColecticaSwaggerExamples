using System;
using Xunit;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Model;
using Colectica.RestClientV1.Client;
using System.Collections.Generic;

namespace CallAPITests.Api
{
    /// <summary>
    /// This class tests <see cref="TagApi"/> on the Colectica Repository 
    /// </summary>
    public class TagApiTest
    {
        Configuration configuration;
        private TagApi tagApiTest;
        private string basePath = "http://localhost:5000";


        [Fact]
        public void OnCreate()
        {
            tagApiTest = new TagApi(this.basePath);
            Assert.NotNull(tagApiTest);
        }

        [Fact]
        public void OnCreateWithOutBasePath()
        {
            tagApiTest = new TagApi();
            Assert.NotNull(tagApiTest);
        }

        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            tagApiTest = new TagApi();
            Assert.NotNull(tagApiTest);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdByVersionTagByTagAddGetAndDeleteTest()
        {
            ApiResponse<object> response;
            configuration = GetClientConfig();
            tagApiTest = new TagApi(configuration);

            response = tagApiTest.ApiV1ItemByAgencyByIdByVersionTagByTagPutWithHttpInfo("int.example", new Guid("65B5D0A6-4367-4680-954E-03D64CC652DD"), 1L, "Test Tag");
            Assert.Equal(200, response.StatusCode);
            List<String> tagsApi = tagApiTest.ApiV1ItemByAgencyByIdByVersionTagGet("int.example", new Guid("65B5D0A6-4367-4680-954E-03D64CC652DD"), 1L);
            Assert.Contains("Test Tag", tagsApi);
            response = tagApiTest.ApiV1ItemByAgencyByIdByVersionTagByTagDeleteWithHttpInfo("int.example", new Guid("65B5D0A6-4367-4680-954E-03D64CC652DD"), 1L, "Test Tag");
            Assert.Equal(200, response.StatusCode);
        }

        /// <summary>  
        ///  This method return and test a kind of Client Configuration <see cref="ConfigTest"/> for calling the API.
        /// </summary>
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
