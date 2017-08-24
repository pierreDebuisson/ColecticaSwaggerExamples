using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{
    /// <summary>
    /// This class tests <see cref="CommentApi"/> on the Colectica Repository 
    /// </summary>
    public class CommentApiTest
    {
        private string basePathTest = "http://localhost:5000";
        private string agencyTest = "int.example";

        private static Configuration configuration;

        /// <summary>
        /// Test of the instanciation of <see cref="CommmentApi"/> with the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OnCreate()
        {
            CommentApi commentApi = new CommentApi(this.basePathTest);
            Assert.NotNull(commentApi.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="CommmentApi"/> without the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OnCreateWithoutBasePath()
        {
            CommentApi commentApi = new CommentApi(this.basePathTest);
            Assert.NotNull(commentApi.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="CommmentApi"/> with test configuration <see cref="ConfigTest"/>
        /// </summary>
        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            CommentApi commentApi = new CommentApi(configuration);
            Assert.NotNull(commentApi.Configuration);
        }

        /// <summary>
        /// test for adding a comment in the Colectica Repository with a <see cref="CreateCommentRequest"/>.
        /// </summary>
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

        /// <summary>
        /// test for getting a comment from the Colectica Repository with a <see cref="UserComment"/>.
        /// </summary>
        [Fact]
        public void ApiV1ItemByAgencyByIdCommentGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            CommentApi commentApiTest = new CommentApi(configuration);

            ApiResponse<List<UserComment>> response = commentApiTest.ApiV1ItemByAgencyByIdCommentGetWithHttpInfo(agencyTest, new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"));
            Assert.Equal(200, response.StatusCode);
            DateTime dt = DateTime.Parse("2017-08-21 20:07:30.023");
            UserComment userCommentToCheck = new UserComment("test of commments", dt, "API_User", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L, "int.example");
            Assert.Contains(userCommentToCheck, response.Data);

        }


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
