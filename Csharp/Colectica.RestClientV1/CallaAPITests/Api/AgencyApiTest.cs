using System;
using Colectica.RestClientV1.Api;
using Xunit;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using CallAPITests.Api;

namespace CallAPITests
{

    public class AgencyAPITest
    {
        private string basePath;


        public AgencyAPITest()
        {
            basePath = "http://localhost:5000";
        }

        [Fact]
        public void OneCreate()
        {
            AgencyApi agencyApiTest = new AgencyApi(this.basePath);
            Assert.NotNull(agencyApiTest.Configuration);
        }

        [Fact]
        public void OneCreateWithoutBasePath()
        {
            AgencyApi agencyApiTest = new AgencyApi();
            Assert.NotNull(agencyApiTest.Configuration);
        }

        [Fact]
        public void OneCreateWithConfiguration()
        {
            AgencyApi agencyApiTest = new AgencyApi(GetClientConfig());
            Assert.NotNull(agencyApiTest.Configuration);
        }

        [Fact]
        public void ApiV1AgencyByAgencyDeleteWithHttpInfo()
        {
            Configuration configuration = GetClientConfig();
            AgencyApi agencyApiTest = new AgencyApi(configuration);
            ApiResponse<Object> responses = agencyApiTest.ApiV1AgencyByAgencyDeleteWithHttpInfo("int.example");
            Assert.Equal(200, responses.StatusCode);

            CreateAgencyRequest requestAgency = new CreateAgencyRequest("int.example", "example");
            ApiResponse<Object> responsesCreation = agencyApiTest.ApiV1AgencyPostWithHttpInfo(requestAgency);
            Assert.Equal(200, responsesCreation.StatusCode);
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
