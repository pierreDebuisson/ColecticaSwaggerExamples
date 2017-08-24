using CallAPITests.Api;
using Colectica.RestClientV1.Api;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace CallAPITests
{
    /// <summary>
    /// This class tests <see cref="ItemApi"/> on the Colectica Repository 
    /// </summary>
    public class ItemAPITest
    {
        /// <summary>  
        ///  This method return and test a kind of Client Configuration for calling the API.
        /// </summary>
        [Theory]
        [InlineData("int.example", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1")]
        public void GetListItemsByAgencyByParentIDByItemTypeTest(string agency, string parentID, string itemType)
        {
            //Converting string parameter to GUID
            Guid itemTypeGuid = new Guid(itemType);
            var configuration = GetClientConfig();

            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);

            //GET the list of GUID            
            GetLatestItemsRequest request = new GetLatestItemsRequest
            {
                Identifiers = new List<IdentifierInRequest>()
            };
            foreach (IdentifierTriple itemTriple in responseSets)
            {
                request.Identifiers.Add(new IdentifierInRequest(itemTriple.Item3, itemTriple.Item1, itemTriple.Item2));
            }
            var instanceList = new ItemApi(configuration);
            var responseList = instanceList.ApiV1ItemGetListLatestPost(request);

            //TODO: to developp
            //var mapItemsChild = new Dictionary<RepositoryItem, List<RepositoryItem>>();
            foreach (RepositoryItem item in responseList)
            {
                if (item != null && item.ItemType == itemTypeGuid && item.AgencyId == agency)
                {
                    Console.WriteLine(item.ToJson());
                }
            }

        }


        [Theory]
        [InlineData("52c5dd34-1b5f-460b-8904-6f0f2897f6a1")]
        public void GetListItemsByParentIDTest(string parentID)
        {
            
            var configuration = GetClientConfig();
           

            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);

            //GET the list of GUID            
            GetLatestItemsRequest request = new GetLatestItemsRequest
            {
                Identifiers = new List<IdentifierInRequest>()
            };
            foreach (IdentifierTriple itemTriple in responseSets)
            {
                request.Identifiers.Add(new IdentifierInRequest(itemTriple.Item3, itemTriple.Item1, itemTriple.Item2));
            }
            var instanceList = new ItemApi(configuration);
            var responseList = instanceList.ApiV1ItemGetListLatestPost(request);
            foreach (RepositoryItem item in responseList)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToJson());
                }
            }

        }

        [Fact]
        public void ApiV1ItemByAgencyByIdByVersionDescriptionGetWithHttpInfoTest()
        {
            var configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);
            var instanceList = new ItemApi(configuration);
            var response = instanceList.ApiV1ItemByAgencyByIdByVersionDescriptionGetWithHttpInfo("int.example", guid, 1L);
            Assert.Equal(200, response.StatusCode);

        }

        [Fact]
        public void ApiV1ItemByAgencyByIdGetTest()
        {
            var configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);
            var instanceList = new ItemApi(configuration);
            var response = instanceList.ApiV1ItemByAgencyByIdGet("int.example", guid);
            Assert.NotNull(response.AgencyId);

        }

        [Fact]
        public void ApiV1ItemGetDescriptionsPostTest()
        {
            var configuration = GetClientConfig();
            //GET the Sets
            var instanceSets = new Colectica.RestClientV1.Api.SetApi(configuration);
            Guid guid = new Guid("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet("int.example", guid, 1);
            var instanceList = new ItemApi(configuration);
            GetRepositoryItemDescriptionsRequest request = new GetRepositoryItemDescriptionsRequest();
            List<IdentifierInRequest> identifiers = new List<IdentifierInRequest>();
            IdentifierInRequest item = new IdentifierInRequest("int.example", guid, 1L);
            identifiers.Add(item);
            request.Identifiers = identifiers;
            var response = instanceList.ApiV1ItemGetDescriptionsPost(request);
            Assert.NotEmpty(response);

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
