using Colectica.RestClientV1.Model;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    public class RattingApiTest
    {

        private RatingApi ratingApiTest;
        private Configuration configuration;
        private string basePath = "http://localhost:5000";

        [Fact]
        public void OneCreate()
        {
            ratingApiTest = new RatingApi(this.basePath);
            Assert.NotNull(ratingApiTest.Configuration);
        }

        [Fact]
        public void OneCreateWithoutBasepath()
        {
            ratingApiTest = new RatingApi();
            Assert.NotNull(ratingApiTest.Configuration);
        }

        [Fact]
        public void OneCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            ratingApiTest = new RatingApi();
            Assert.NotNull(ratingApiTest.Configuration);
        }

        [Fact]
        public void ApiV1ItemByAgencyByIdByVersionRatingPostWithHttpInfoTest()
        {
            configuration = GetClientConfig();
            ratingApiTest = new RatingApi(configuration);
            ApiResponse<object> response = ratingApiTest.ApiV1ItemByAgencyByIdByVersionRatingPostWithHttpInfo("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L, 3);
            UserRating userRating = new UserRating(3, "API_User", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), 1L, "int.example");
            List<UserRating> userRatings = ratingApiTest.ApiV1ItemByAgencyByIdByVersionRatingGet("int.example", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), "1");
            Assert.Contains(userRating, userRatings);
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
