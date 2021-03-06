﻿using Colectica.RestClientV1.Model;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    /// <summary>
    /// This class tests <see cref="RatingApi"/> on the Colectica Repository 
    /// </summary>
    public class RatingApiTest
    {

        private RatingApi ratingApiTest;
        private Configuration configuration;
        private string basePath = "http://localhost:5000";

        /// <summary>
        /// Test of the instanciation of <see cref="RatingApi"/> with the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OneCreate()
        {
            ratingApiTest = new RatingApi(this.basePath);
            Assert.NotNull(ratingApiTest.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="RatingApi"/> without the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OneCreateWithoutBasepath()
        {
            ratingApiTest = new RatingApi();
            Assert.NotNull(ratingApiTest.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="RatingApi"/> with the configTest <see cref="ConfigTest"/>
        /// </summary>
        [Fact]
        public void OneCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            ratingApiTest = new RatingApi();
            Assert.NotNull(ratingApiTest.Configuration);
        }

        /// <summary>
        /// Test of the addition of  a <see cref="RatingApi"/> instance to the Colectica repository.
        /// </summary>
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
        ///  This method return and test a kind of Client Configuration <see cref="ConfigTest"/> for calling the API.
        /// </summary>
        public Configuration GetClientConfig()
        {
            ConfigTest configTest = new ConfigTest();
            var client = new ApiClient(configTest.BasePath);

            var configuration = new Configuration(client);
            configuration.ApiKey.Add(configTest.ApiKeyPrefix, configTest.ApiKey);
            configuration.AddDefaultHeader(configTest.ApiKeyPrefix, configTest.ApiKey);
            Assert.NotNull(configuration);
            return configuration;

        }

    }
}
