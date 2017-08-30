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

        /// <summary>
        /// Test of the instanciation of <see cref="RepositoryApi"/> with the basePath (part of the URL)
        /// </summary>
        [Fact]
        public void OnCreate()
        {
            RepositoryApi repositoryApi = new RepositoryApi("http://localhost:5000");
            Assert.NotNull(repositoryApi);
        }

        /// <summary>
        /// Test of the instanciation of <see cref="RepositoryApi"/> without the basePath.
        /// </summary>
        [Fact]
        public void OnCreateWithoutBasePath()
        {
            RepositoryApi repositoryApi = new RepositoryApi();
            Assert.NotNull(repositoryApi);
            Assert.NotNull(repositoryApi.Configuration);
        }

        /// <summary>
        /// Test of the obtention of a<see cref="RepositoryApi"/> 
        /// </summary>
        [Fact]
        public void ApiV1RepositoryInfoGetTest()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            RepositoryInfo info = repositoryApi.ApiV1RepositoryInfoGet();
            Assert.NotNull(info);

        }
        /// <summary>
        /// Test of the obtention of informations about <see cref="RepositoryApi"/> with the HTTP Header a<see cref="ApiResponse{T}
        /// "/>
        /// </summary>
        [Fact]
        public void ApiV1RepositoryInfoGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            ApiResponse<RepositoryInfo> info = repositoryApi.ApiV1RepositoryInfoGetWithHttpInfo();
            Assert.NotNull(info);
            Assert.Equal(200, info.StatusCode);
        }

        /// <summary>
        /// Test of the creation of a task a<see cref="Task"/> in the queue.
        /// </summary>
        [Fact]
        public void AsyncApiV1RepositoryInfoGetTest()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryInfoGetAsync();
            Assert.NotNull(task.Id.ToString());

        }

        /// <summary>
        /// Test of the creation of a task a<see cref="Task"/> with the HTTP Header a<see cref="ApiResponse{T}
        /// "/>
        /// </summary>
        [Fact]
        public void AsyncApiV1RepositoryInfoGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryInfoGetAsyncWithHttpInfo();
            Assert.NotNull(task.Id.ToString());
        }

        /// <summary>
        /// Test of the obtention of statistics about <see cref="RepositoryApi"/> 
        /// />
        /// </summary>
        [Fact]
        public void ApiV1RepositoryStatisticsGet()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            RepositoryStatistics stats = repositoryApi.ApiV1RepositoryStatisticsGet();
            Assert.NotNull(stats);
        }

        /// <summary>
        /// Test of the creation of a task a<see cref="Task"/> 
        /// </summary>
        [Fact]
        public void AsyncApiV1RepositoryStatisticsGet()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            Task task = repositoryApi.ApiV1RepositoryStatisticsGetAsync();
            Assert.NotNull(task.Id.ToString());
        }

        /// <summary>
        /// Test of the obtention of statistics about <see cref="RepositoryApi"/> 
        ///  with HTTP header./>
        /// </summary>
        [Fact]
        public void ApiV1RepositoryStatisticsGetWithHttpInfo()
        {
            configuration = GetClientConfig();
            RepositoryApi repositoryApi = new RepositoryApi(configuration);
            ApiResponse<RepositoryStatistics> stats = repositoryApi.ApiV1RepositoryStatisticsGetWithHttpInfo();
            Assert.Equal(200, stats.StatusCode);
        }
        /// <summary>
        /// Test of the creation of a task a<see cref="Task"/> 
        ///with the HTTP Header a<see cref="ApiResponse{T}
        /// "/>
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
            var client = new ApiClient(configTest.BasePath);

            var configuration = new Configuration(client);
            configuration.ApiKey.Add(configTest.ApiKeyPrefix, configTest.ApiKey);
            configuration.AddDefaultHeader(configTest.ApiKeyPrefix, configTest.ApiKey);
            Assert.NotNull(configuration);
            return configuration;

        }
    }
}
