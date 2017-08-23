using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests.Api
{
    
    public class SettingApiTest
    {
        private Configuration configuration;
        private string basePath = "http://localhost:5000";

        [Fact]
        public void OnCreate()
        {

            SettingApi settingApiTest = new SettingApi(this.basePath);
            
            Assert.NotNull(settingApiTest);
        }

        [Fact]
        public void OnCreateWithConfiguration()
        {
            configuration = GetClientConfig();
            SettingApi settingApiTest = new SettingApi(configuration);

            Assert.NotNull(settingApiTest);
        }

        [Fact]
        public void OnCreateWithoutBasePath()
        {
            configuration = GetClientConfig();
            SettingApi settingApiTest = new SettingApi(configuration);

            Assert.NotNull(settingApiTest);
        }



        [Fact]
        public void ApiV1SettingBySettingAddGetAndDeleteWithHttpInfoTest()
        {
            configuration = GetClientConfig();
            SettingApi settingApiTest = new SettingApi(configuration);
            
            RepositorySetting repositorySetting = new RepositorySetting("Test Setting Name", "TestSettingValue", 1L);
            
            ApiResponse<object> response = settingApiTest.ApiV1SettingPostWithHttpInfo(repositorySetting);
            Assert.Equal(200, response.StatusCode);
            ApiResponse<List<RepositorySetting>> responseGet = settingApiTest.ApiV1SettingGetWithHttpInfo();
            Assert.Equal(200, responseGet.StatusCode);
            Assert.Contains(repositorySetting, responseGet.Data);

            ApiResponse<object> responseDelete = settingApiTest.ApiV1SettingBySettingDeleteWithHttpInfo("Test Setting Name");
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
