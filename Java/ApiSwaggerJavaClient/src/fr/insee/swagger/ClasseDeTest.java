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
import io.swagger.client.api.SetApi;
import io.swagger.client.model.GetLatestItemsRequest;
import io.swagger.client.model.IdentifierInRequest;
import io.swagger.client.model.IdentifierTriple;
import io.swagger.client.model.RepositoryItem;
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
	// Configuration a appliquer à l'APIClient
	private static Configuration configuration;

	public static void main(String[] args) throws IOException {
		
		

		 
		try {
			configuration = getConfiguration();
			System.out.println("TEST de la méthode par itemType :");
			// TODO: Remplacer les valeurs
			System.out.println(getListItemsByAgencyByParentIdByItemType("int.example",
					"52c5dd34-1b5f-460b-8904-6f0f2897f6a1", "a1bb19bd-a24a-4443-8728-a6ad80eb42b8", 1L));
			System.out.println("TEST de la méthode par ObjetParent :");
			// TODO: Remplacer les valeurs
			System.out.println(
					getListItemsByAgencyByParentIdByVersion("int.example", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1", 1L));

		} catch (Exception e) {

			e.printStackTrace();
		}
		 

	}

	/**
	 * Méthode de valorisation des informations de connexion à l' API
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
		
		
		

		configuration.setDefaultApiClient(client);
		return configuration;
	}

	/**
	 * Méthode de retour de l'ensemble des items Enfants de l'Item Parent (via
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
	private static String getListItemsByAgencyByParentIdByVersion(String agency, String parentID, Long version)
			throws ApiException {

		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString(parentID);

		List<IdentifierTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionGet(agency, guidParent,
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
			if (item != null && agency.equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// Cas de l'exception : à gérer proprement
			else {
				// throw new Exception
			}
		}
		return strBuild.toString();
	}

	/**
	 * Méthode de retour des items Enfants de l'Item Parent (via parentID) ayant
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
	private static String getListItemsByAgencyByParentIdByItemType(String agency, String parentID, String itemType,
			Long version) throws ApiException {
		// Converting string parameter to GUID
		UUID itemTypeGuid = UUID.fromString(itemType);

		// Récupère les infos du repository
		// RepositoryApi instanceRepository = new RepositoryApi(client);
		// RepositoryInfo repositoryInfo =
		// instanceRepository.apiV1RepositoryInfoGet();
		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString(parentID);

		List<TypedIdTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionTypedGet(agency, guidParent,
				version);

		// GET the list of GUID
		GetLatestItemsRequest request = new GetLatestItemsRequest();
		List<IdentifierInRequest> identifiers = new ArrayList<IdentifierInRequest>();

		IdentifierInRequest idFor;
		for (TypedIdTriple typedItemTriple : responseSets) {
			// Comparaison avec le type passé en paramètre
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
			if (item != null && agency.equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// // Cas de l'exception : à gérer proprement
			else {
				// // throw new Exception
			}
		}
		return strBuild.toString();
	}

}
