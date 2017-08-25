using System;
using Xunit;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;

namespace CallAPITests.Api
{
    /// <summary>
    /// This class tests <see cref="EventApi"/> on the Colectica Repository 
    /// </summary>
    public class EventApiTest
    {
        private EventApi eventApitest;
        private Configuration configuration;
        private string basePath = "http://localhost:5000";
        private DateTime dt = DateTime.Now;

        /// <summary>
        /// This method tests the instanciation of <see cref="EventApi"/> with the Configuration Test <see cref="ConfigTest"/>
        /// </summary>
        [Fact]
        public void OneCreateWithConfig()
        {
            configuration = GetClientConfig();
            EventApi eventApitest = new EventApi(configuration);
            Assert.NotNull(eventApitest.Configuration);
        }

        /// <summary>
        /// This method tests the instanciation of <see cref="EventApi"/> with the basePath
        /// </summary>
        [Fact]
        public void OneCreate()
        {
            eventApitest = new EventApi(this.basePath);
            Assert.NotNull(eventApitest.Configuration);
        }

        /// <summary>
        /// This method tests the instanciation of <see cref="EventApi"/> without the basePath
        /// </summary>
        [Fact]
        public void OneCreateWithoutBasePath()
        {
            eventApitest = new EventApi();
            Assert.NotNull(eventApitest.Configuration);
        }

        /// <summary>
        /// This method tests the addition of an of <see cref="EventApi"/> to the Repository
        /// </summary>
        [Fact]
        public void ApiV1EventPostWithHttpInfo()
        {
            configuration = GetClientConfig();
            LoggedEvent loggedEvent = new LoggedEvent(dt, "Portal", 1, 7, 1, "anonymous", "Test Event", new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1"), "int.example", 1L);
            eventApitest = new EventApi(configuration);
            ApiResponse<object> response = eventApitest.ApiV1EventPostWithHttpInfo(loggedEvent);
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
