using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    public class CommmentApi
    {
        private string basePathTest = "http://localhost:5000";
        private string agencyTest = "int.example";

        private static Configuration configuration;

        [Fact]
        public void OnCreate()
        {
            CommentApi commentApi = new CommentApi(this.basePathTest);
            Assert.NotNull(commentApi.Configuration);
        }

        [Fact]
        public void OnCreateWithoutBasePath()
        {
            CommentApi commentApi = new CommentApi(this.basePathTest);
            Assert.NotNull(commentApi.Configuration);
        }

        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            CommentApi commentApi = new CommentApi(configuration);
            Assert.NotNull(commentApi.Configuration);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdByVersionCommentPostAsyncWithHttpInfo()
        {
            configuration = GetClientConfig();
            CommentApi commentApiTest = new CommentApi(configuration);
            CreateCommentRequest createcommentRequest = new CreateCommentRequest
            {
                Comment = "test of commments"
            };

            ApiResponse<object> response = commentApiTest.ApiV1ItemByAgencyByIdByVersionCommentPostWithHttpInfo(agencyTest, new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L, createcommentRequest);
            Assert.Equal(200, response.StatusCode);

        }

        [Fact]
        public void ApiV1ItemByAgencyByIdByVersionCommentGetAsyncWithHttpInfo()
        {
            configuration = GetClientConfig();
            CommentApi commentApiTest = new CommentApi(configuration);
            
            ApiResponse<List<UserComment>> response = commentApiTest.ApiV1ItemByAgencyByIdCommentGetWithHttpInfo(agencyTest, new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Equal(200, response.StatusCode);
            DateTime dt = DateTime.Parse("2017-08-21 20:07:30.023");
            UserComment userCommentToCheck = new UserComment("test of commments", dt, "API_User", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L, "int.example");
            Assert.Contains(userCommentToCheck, response.Data);

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
