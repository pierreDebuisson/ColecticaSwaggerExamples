package fr.insee.swagger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLSocketFactory;
import javax.security.cert.Certificate;

import io.swagger.client.*;
import io.swagger.client.api.ItemApi;
import io.swagger.client.api.QueryApi;
import io.swagger.client.api.SetApi;
import io.swagger.client.model.GetLatestItemsRequest;
import io.swagger.client.model.IdentifierInRequest;
import io.swagger.client.model.IdentifierTriple;
import io.swagger.client.model.RepositoryItem;
import io.swagger.client.model.SearchTypedSetRequest;
import io.swagger.client.model.SetSearchFacet;
import io.swagger.client.model.TypedIdTriple;

import com.google.gson.*;
import com.squareup.okhttp.CertificatePinner;
import com.squareup.okhttp.OkHttpClient;

/**
 * 
 * @author pierre
 *
 */
public class ClasseDeTest {

	private static ApiClient client = new ApiClient();
	// Configuration a appliquer � l'APIClient
	private static Configuration configuration;

	public static void main(String[] args) throws IOException {

		try {
			configuration = getConfiguration();
			System.out.println("TEST de la m�thode par itemType :");
			// TODO: Remplacer les valeurs
			System.out.println(getListItemsByAgencyByParentIdByItemType("int.example",
					"52c5dd34-1b5f-460b-8904-6f0f2897f6a1", "a1bb19bd-a24a-4443-8728-a6ad80eb42b8", 1L));
			System.out.println("TEST de la m�thode par ObjetParent :");
			// TODO: Remplacer les valeurs
			System.out.println(
					getListItemsByAgencyByParentIdByVersion("int.example", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1", 1L));
			// Test de la m�thode POST

			System.out.println("TEST de la m�thode getSets Par Type et Objet Parent :");
			System.out.println(getSetsByItemType("52c5dd34-1b5f-460b-8904-6f0f2897f6a1",
					"a1bb19bd-a24a-4443-8728-a6ad80eb42b8", "int.example", 1L));
		} catch (Exception e) {

			e.printStackTrace();
		}

	}

	/**
	 * M�thode de valorisation des informations de connexion � l' API
	 * 
	 * @return Configuration du client
	 * @throws IOException
	 */
	private static Configuration getConfiguration() throws IOException {
		// TODO: Mettre la configuration Hermes
		 client.setBasePath("https://quill.colectica.org/");
		 configuration = new Configuration();
		 client.setApiKey("QUILLTEST");
		 client.addDefaultHeader("api_key", "QUILLTEST");

//		client.setBasePath("http://localhost:5000");
//		configuration = new Configuration();
//		client.setApiKey("ADMINKEY");
//		client.addDefaultHeader("api_key", "ADMINKEY");

		configuration.setDefaultApiClient(client);
		return configuration;
	}

	/**
	 * M�thode de retour de l'ensemble des items Enfants de l'Item Parent (via
	 * parentID) en format json
	 * 
	 * @param String
	 *            agency
	 * @param String
	 *            parentID
	 * @param Long
	 *            Version
	 * @return String String ensembleDesItems en Json
	 * @throws ApiException
	 * @version 1.0
	 */
	private static String getListItemsByAgencyByParentIdByVersion(String agencyId, String parentID, Long version)
			throws ApiException {

		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString(parentID);

		List<IdentifierTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionGet(agencyId, guidParent,
				version);

		// GET the list of GUID
		GetLatestItemsRequest request = new GetLatestItemsRequest();
		List<IdentifierInRequest> identifiers = new ArrayList<IdentifierInRequest>();

		IdentifierInRequest idFor;
		for (IdentifierTriple itemTriple : responseSets) {
			idFor = new IdentifierInRequest();
			idFor.agencyId(itemTriple.getItem3());
			idFor.identifier(itemTriple.getItem1());
			idFor.version(itemTriple.getItem2());
			identifiers.add(idFor);
		}
		request.setIdentifiers(identifiers);

		ItemApi instanceList = new ItemApi(client);
		List<RepositoryItem> responseList = instanceList.apiV1ItemGetListLatestPost(request);

		StringBuilder strBuild = new StringBuilder();
		Gson gson;
		for (RepositoryItem item : responseList) {
			if (item != null && agencyId.equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// Cas de l'exception : � g�rer proprement
			else {
				// throw new Exception
			}
		}
		return strBuild.toString();
	}

	/**
	 * M�thode de retour des items Enfants de l'Item Parent (via parentID) ayant
	 * un type particulier en format json
	 * 
	 * @param String
	 *            agency
	 * @param String
	 *            parentID
	 * @param Long
	 *            Version
	 * @param String
	 *            itemType
	 * @return String String ensembleDesItems en Json
	 * @throws ApiException
	 * @version 1.0
	 */
	private static String getListItemsByAgencyByParentIdByItemType(String agencyId, String parentID, String itemType,
			Long version) throws ApiException {
		// Converting string parameter to GUID
		UUID itemTypeGuid = UUID.fromString(itemType);

		// R�cup�re les infos du repository
		// RepositoryApi instanceRepository = new RepositoryApi(client);
		// RepositoryInfo repositoryInfo =
		// instanceRepository.apiV1RepositoryInfoGet();
		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString(parentID);

		List<TypedIdTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionTypedGet(agencyId, guidParent,
				version);

		// GET the list of GUID
		GetLatestItemsRequest request = new GetLatestItemsRequest();
		List<IdentifierInRequest> identifiers = new ArrayList<IdentifierInRequest>();

		IdentifierInRequest idFor;
		for (TypedIdTriple typedItemTriple : responseSets) {
			// Comparaison avec le type pass� en param�tre
			if (itemTypeGuid.equals(typedItemTriple.getItem2())) {
				idFor = new IdentifierInRequest();
				idFor.agencyId(typedItemTriple.getItem1().getItem3());
				idFor.identifier(typedItemTriple.getItem1().getItem1());
				idFor.version(typedItemTriple.getItem1().getItem2());
				identifiers.add(idFor);
			}
		}
		request.setIdentifiers(identifiers);

		ItemApi instanceList = new ItemApi(client);
		List<RepositoryItem> responseList = instanceList.apiV1ItemGetListLatestPost(request);

		StringBuilder strBuild = new StringBuilder();
		Gson gson;
		for (RepositoryItem item : responseList) {
			if (item != null && agencyId.equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// // Cas de l'exception : � g�rer proprement
			else {
				// // throw new Exception
			}
		}
		return strBuild.toString();
	}

	private static String getSetsByItemType(String parentID, String itemType, String agencyId, Long version)
			throws ApiException {

		// R�cup�re les infos du repository
		// RepositoryApi instanceRepository = new RepositoryApi(client);
		// RepositoryInfo repositoryInfo =
		// instanceRepository.apiV1RepositoryInfoGet();
		QueryApi instanceQuery = new QueryApi(client);

		IdentifierInRequest identifier = new IdentifierInRequest();
		identifier.setIdentifier(UUID.fromString(parentID));
		identifier.setAgencyId(agencyId);
		identifier.setVersion(version);
		SearchTypedSetRequest searchRequest = new SearchTypedSetRequest();
		searchRequest.setRootItem(identifier);
		SetSearchFacet facet = new SetSearchFacet();
		List<UUID> typeList = new ArrayList<UUID>();
		typeList.add(UUID.fromString(itemType));
		facet.setItemTypes(typeList);
		searchRequest.setFacet(facet);
		List<TypedIdTriple> responseQuery = instanceQuery.apiV1QuerySetPost(searchRequest);

		StringBuilder strBuild = new StringBuilder();
		Gson gson;
		for (TypedIdTriple set : responseQuery) {
			// Comparaison avec le nom de l'entreprise de l'IdentifierTriple
			if (set != null && agencyId.equals(set.getItem1().getItem3())) {
				//TODO : afficher szulement iTem1 + remplacement de Item1,2,3 par attributs
				gson = new Gson();
				strBuild.append(gson.toJson(set));
				strBuild.append("\n");
			}
			// // Cas de l'exception : � g�rer proprement
			else {
				// // throw new Exception
			}
		}
		return strBuild.toString();
	}

}
