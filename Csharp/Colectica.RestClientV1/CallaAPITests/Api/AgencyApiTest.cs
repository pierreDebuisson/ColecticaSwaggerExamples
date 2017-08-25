using System;
using Colectica.RestClientV1.Api;
using Xunit;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using CallAPITests.Api;

namespace CallAPITests
{
    /// <summary>
    /// This class tests <see cref="AgencyApi"/> on the Colectica Repository 
    /// </summary>
    public class AgencyAPITest
    {
        private string basePath;


        public AgencyAPITest()
        {
            basePath = "http://localhost:5000";
        }

        /// <summary>
        /// Test of the instanciation of <see cref="AgencyApi"/> with the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OneCreate()
        {
            AgencyApi agencyApiTest = new AgencyApi(this.basePath);
            Assert.NotNull(agencyApiTest.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="AgencyApi"/> whithout the basePath
        /// </summary>
        [Fact]
        public void OneCreateWithoutBasePath()
        {
            AgencyApi agencyApiTest = new AgencyApi();
            Assert.NotNull(agencyApiTest.Configuration);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="AgencyApi"/> with the test Configuration
        /// </summary>
        [Fact]
        public void OneCreateWithConfiguration()
        {
            AgencyApi agencyApiTest = new AgencyApi(GetClientConfig());
            Assert.NotNull(agencyApiTest.Configuration);
        }

        /// <summary>
        /// Test of the method ApiV1AgencyByAgencyDeleteWithHttpInfo() as a [Fact] (Always True) 
        /// you can use [Theory]("param1",param2") instead. Examples: <see cref="ItemAPITest"/>
        /// or <see cref="SetApiTest"/>
        /// </summary>
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
        ///  This method return and test a kind of Client Configuration <see cref="ConfigTest"/> for calling the API.
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
