using System;
using Xunit;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Model;
using Colectica.RestClientV1.Client;
using System.Threading.Tasks;

namespace CallAPITests.Api
{
    /// <summary>
    /// This class tests <see cref="RepositoryApi"/> on the Colectica Repository 
    /// </summary>
    public class RepositoryApiTest
    {

        private Configuration configuration;

        [Fact]
        public void OnCreate()
        {
            RepositoryApi repositoryApi = new RepositoryApi("http://localhost:5000");
            Assert.NotNull(repositoryApi);
        }

        [Fact]
        public void OnCreateWithoutBasePath()
        {
            RepositoryApi repositoryApi = new RepositoryApi();
            Assert.NotNull(repositoryApi);
            Assert.NotNull(repositoryApi.Configuration);
        }

        [Fact]
        public void ApiV1RepositoryInfoGetTest()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            RepositoryInfo info = repositoryApi.ApiV1RepositoryInfoGet();
            Assert.NotNull(info);

        }

        [Fact]
        public void ApiV1RepositoryInfoGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            ApiResponse<RepositoryInfo> info = repositoryApi.ApiV1RepositoryInfoGetWithHttpInfo();
            Assert.NotNull(info);
            Assert.Equal(200, info.StatusCode);
        }

        [Fact]
        public void AsyncApiV1RepositoryInfoGetTest()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryInfoGetAsync();
            Assert.NotNull(task.Id.ToString());

        }

        [Fact]
        public void AsyncApiV1RepositoryInfoGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryInfoGetAsyncWithHttpInfo();
            Assert.NotNull(task.Id.ToString());
        }

        [Fact]
        public void ApiV1RepositoryStatisticsGet()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            RepositoryStatistics stats = repositoryApi.ApiV1RepositoryStatisticsGet();
            Assert.NotNull(stats);
        }

        [Fact]
        public void AsyncApiV1RepositoryStatisticsGet()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryStatisticsGetAsync();
            Assert.NotNull(task.Id.ToString());
        }

        [Fact]
        public void ApiV1RepositoryStatisticsGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            ApiResponse<RepositoryStatistics> stats = repositoryApi.ApiV1RepositoryStatisticsGetWithHttpInfo();
            Assert.Equal(200,stats.StatusCode);
        }

        [Fact]
        public void AsyncApiV1RepositoryStatisticsGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryStatisticsGetAsyncWithHttpInfo();
            Assert.NotNull(task.Id.ToString());
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
