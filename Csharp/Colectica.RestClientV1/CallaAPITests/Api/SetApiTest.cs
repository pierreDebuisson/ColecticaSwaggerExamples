using System;
using Xunit;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using CallAPITests.Api;

namespace CallAPITests
{
    public class SetApiTest
    {

        [Theory]
        [InlineData("52c5dd34-1b5f-460b-8904-6f0f2897f6a1")]
        public void ApiV1SetByAgencyByIdByVersionGetTest(string parentID)
        {
            Configuration configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);
            Assert.NotNull(responseSets.ToArray());
        }

        [Theory]
        [InlineData("52c5dd34-1b5f-460b-8904-6f0f2897f6a1")]
        public void ApiV1SetByAgencyByIdGetTest(string parentID)
        {
            Configuration configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdGet("int.example", guid);
            Assert.NotNull(responseSets.ToArray());
        }

        [Theory]
        [InlineData("52c5dd34-1b5f-460b-8904-6f0f2897f6a1")]
        public void ApiV1SetByAgencyByIdByVersionGetAsyncTest(string parentID)
        {
            Configuration configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGetAsync("int.example", guid, 1);
            Assert.NotNull(responseSets);
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
