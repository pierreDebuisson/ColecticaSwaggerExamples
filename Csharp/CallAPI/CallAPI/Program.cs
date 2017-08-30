using System;
using Colectica.RestClientV1.Model;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Api;
using System.Collections.Generic;

namespace CallAPI
{

    /// <summary>  
    ///  This class is the main class
    /// </summary> 
    class Program
    {
        static void Main(string[] args)
        {
            ////Using test Guid : You have to replace them by yours.
            //GetListItems("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");
            //Console.WriteLine("/////////////////////////////////////////////////////////");
            //Console.WriteLine("/////////////////////////////////////////////////////////");
            //Console.WriteLine("/////////////////////////////////////////////////////////" + "\n");
            //GetListItems("int.example", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1", "a1bb19bd-a24a-4443-8728-a6ad80eb42b8");
            //Console.WriteLine("/////////////////////////////////////////////////////////");
            //Console.WriteLine("/////////////////////////////////////////////////////////");
            //Console.WriteLine("/////////////////////////////////////////////////////////" + "\n");
            //GetListItems("int.example", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1", "a1bb19bd-a24a-4443-8728-a6ad80eb42b8", 2L);
            var client = new ApiClient("https://quill.colectica.org");
            var config = new Configuration(client);
            config.DefaultHeader.Add("api_key", "QUILLTEST");

            var api = new RepositoryApi(config);
            RepositoryInfo response = api.ApiV1RepositoryInfoGet();
            Console.WriteLine(response.ToJson());
            Console.ReadLine();
        }

        /// <summary>
        /// Get the list of children Items for the parentID for a specific agency 
        /// and a specific type.
        /// </summary>
        /// <param name="agency"></param>
        /// <param name="parentID"></param>
        /// <param name="itemType"></param>
        private static void GetListItems(string agency, string parentID, string itemType)
        {
            //Converting string parameter to GUID
            Guid itemTypeGuid = new Guid(itemType);
            //GET the RepositoryInfo
            var configuration = GetClientConfig();
            var instance = new RepositoryApi(configuration);
            var response = instance.ApiV1RepositoryInfoGet();
            Console.WriteLine(response.ToJson());
            //GET the Sets
            var instanceSets = new SetApi(configuration);
            Guid guid = new Guid(parentID);
            var responseSets = instanceSets.ApiV1SetByAgencyByIdByVersionGet(agency, guid, 1);
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
                if (item != null && item.ItemType == itemTypeGuid && item.AgencyId == agency)
                {
                    Console.WriteLine(item.ToJson());
                }
                //TODO: Exception 
                else 
                {
                    //throw new Exception
                }
            }

        }

        /// <summary>
        /// Get the list of children Items for the parentID for a specific agency 
        /// and a specific type with a limit of objects returned.
        /// </summary>
        /// <param name="agency"></param>
        /// <param name="parentID"></param>
        /// <param name="itemType"></param>
        /// <param name="limitMax"></param>
        private static void GetListItems(string agency, string parentID, string itemType, long limitMax)
        {
            //Converting string parameter to GUID
            Guid itemTypeGuid = new Guid(itemType);

            //GET the RepositoryInfo
            var configuration = GetClientConfig();
            var instance = new RepositoryApi(configuration);
            var response = instance.ApiV1RepositoryInfoGet();

            //GET the Sets
            var instanceSets = new SetApi(configuration);
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
            long countdown = 0L;
            foreach (RepositoryItem item in responseList)
            {
                if (countdown <= limitMax)
                {
                    if (item != null && item.ItemType == itemTypeGuid && item.AgencyId == agency)
                    {
                        Console.WriteLine(item.ToJson());
                    }

                }
                countdown++;
            }

        }

        /// <summary>
        /// Get the list of children Items for the Parent.
        /// </summary>
        /// <param name="parentID"></param>
        private static void GetListItems(string parentID)
        {

            //GET the RepositoryInfo
            var configuration = GetClientConfig();
            var instance = new RepositoryApi(configuration);
            var response = instance.ApiV1RepositoryInfoGet();
            //GET the Sets
            var instanceSets = new SetApi(configuration);
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



        /// <summary>  
        ///  This method return a kind of Client Configuration for calling the API.
        /// </summary>
        private static Configuration GetClientConfig()
        {
            var client = new ApiClient("http://quill.colectica.org/");

            var configuration = new Configuration(client);
            configuration.ApiKey.Add("api_key", "QUILLTEST");
            configuration.AddDefaultHeader("api_key", "QUILLTEST");
            return configuration;

        }


    }
}
