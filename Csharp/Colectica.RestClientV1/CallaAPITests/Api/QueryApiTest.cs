using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{

    public class QueryApiTest
    {
        private QueryApi queryApiTest;
        private Configuration configuratiopn;
        private string basePath = "http://localhost:5000";

        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuratiopn = GetClientConfig();
            queryApiTest = new QueryApi(configuratiopn);
            Assert.NotNull(queryApiTest.Configuration);
        }

        [Fact]
        public void OnCreateWithoutPath()
        {
            queryApiTest = new QueryApi();
            Assert.NotNull(queryApiTest.Configuration);
        }

        [Fact]
        public void OnCreate()
        {
            queryApiTest = new QueryApi(this.basePath);
            Assert.NotNull(queryApiTest.Configuration);
        }

        //[Fact]
        //public void ApiV1QueryPostTest()
        //{
        //    configuratiopn = GetClientConfig();
        //    queryApiTest = new QueryApi(configuratiopn);
        //    List<string> cultures = new System.Collections.Generic.List<string>
        //    {
        //        "en-US"
        //    };
        //    SearchRequest searchRequest = new SearchRequest(cultures);
        //    SearchResponse response = queryApiTest.ApiV1QueryPost(searchRequest);
            
        //    Assert.NotNull(response);
        //}
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
