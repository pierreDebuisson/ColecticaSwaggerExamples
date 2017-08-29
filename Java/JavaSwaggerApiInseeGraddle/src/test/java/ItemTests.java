import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

import org.junit.Test;

import com.google.gson.Gson;

import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.Configuration;
import io.swagger.client.api.ItemApi;
import io.swagger.client.api.SetApi;
import io.swagger.client.model.GetLatestItemsRequest;
import io.swagger.client.model.IdentifierInRequest;
import io.swagger.client.model.IdentifierTriple;
import io.swagger.client.model.RepositoryItem;
import io.swagger.client.model.TypedIdTriple;

public class ItemTests {
	private static ApiClient client = new ApiClient();
	// Configuration a appliquer à l'APIClient
	private static Configuration configuration = getConfiguration();

	/**
	 * Méthode de test de retour de l'ensemble des items Enfants de l'Item
	 * Parent (via parentID) en format json
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
	@Test
	public void getListItemsByAgencyByParentIdByVersionTest() throws ApiException {
		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");

		List<IdentifierTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionGet("int.example", guidParent,
				1L);

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
			if (item != null && "int.example".equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// Cas de l'exception : à gérer proprement
			else {
				// throw new Exception
			}
		}
		assertNotNull(strBuild);
		assertTrue(strBuild.length() > 1);
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
	@Test
	public void getListItemsByAgencyByParentIdByItemTypeTest() throws ApiException {
		// Converting string parameter to GUID
		UUID itemTypeGuid = UUID.fromString("a1bb19bd-a24a-4443-8728-a6ad80eb42b8");

		// Récupère les infos du repository
		// RepositoryApi instanceRepository = new RepositoryApi(client);
		// RepositoryInfo repositoryInfo =
		// instanceRepository.apiV1RepositoryInfoGet();
		SetApi instanceSets = new SetApi(client);
		UUID guidParent = UUID.fromString("52c5dd34-1b5f-460b-8904-6f0f2897f6a1");

		List<TypedIdTriple> responseSets = instanceSets.apiV1SetByAgencyByIdByVersionTypedGet("int.example", guidParent,
				1L);

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
			if (item != null && "int.example".equals(item.getAgencyId())) {
				gson = new Gson();
				strBuild.append(gson.toJson(item));
				strBuild.append("\n");
			}
			// // Cas de l'exception : à gérer proprement
			else {
				// // throw new Exception
			}
		}

		assertNotNull(strBuild);
		assertTrue(strBuild.length() > 1);

	}

	/**
	 * Méthode de valorisation des informations de connexion à l' API
	 * 
	 * @return Configuration du client
	 */
	private static Configuration getConfiguration() {
		// TODO: Mettre la configuration Hermes
		client.setBasePath("http://localhost:5000");
		configuration = new Configuration();
		client.setApiKey("ADMINKEY");
		client.addDefaultHeader("api_key", "ADMINKEY");
		// Reglages pour le certificat
		// InputStream sslCaCert;
		// client.setSslCaCert(sslCaCert);

		configuration.setDefaultApiClient(client);
		return configuration;
	}

}
