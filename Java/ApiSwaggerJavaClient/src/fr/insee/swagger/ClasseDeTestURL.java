package fr.insee.swagger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;

import javax.net.ssl.HttpsURLConnection;
import org.json.JSONArray;
import org.json.JSONObject;
import com.google.gson.Gson;

public class ClasseDeTestURL {
	// TODO: Mettre la configuration appropriée
	private String basePath = "http://localhost:5000";
	private String apiKey = "ADMINKEY";

	public static void main(String[] args) throws IOException {
		String agency = "int.example";
		String version = "1";
		String idParent = "52c5dd34-1b5f-460b-8904-6f0f2897f6a1";
		ClasseDeTestURL tests = new ClasseDeTestURL();
		List<Identifier> ids = tests.getSetsByAgencyIdVersion(agency, idParent, version);
		tests.getListItemsByIdentifiers(ids);
		System.out.println("Test de la méthode GET Sets by Type :");
		tests.getSetsByItemType(idParent, "a1bb19bd-a24a-4443-8728-a6ad80eb42b8", agency, version);
		tests.NewEvent();																										//TODO: construire le fragment XML
		tests.NewItem("7E47C269-BCAB-40F7-A778-AF7BBC4E3D00", "int.example", Long.valueOf(version), "fragmentXML", "1", "test",
				true, false, false, "c0ca1bd4-1839-4233-a5b5-906da0302b89");

	}

	/**
	 * Méthode de retour des Sets du repository
	 * 
	 * @param agency
	 * @param idParent
	 * @param version
	 * @return
	 * @throws IOException
	 */
	private List<Identifier> getSetsByAgencyIdVersion(String agency, String idParent, String version)
			throws IOException {
		String httpsURL = basePath + "/api/v1/set/" + agency + "/" + idParent + "/" + version + "?api_key=" + apiKey;
		URL myUrl = new URL(httpsURL);
		java.io.InputStream is;
		if (myUrl.toString().contains("https")) {
			HttpsURLConnection conn = (HttpsURLConnection) myUrl.openConnection();
			is = conn.getInputStream();
		} else {
			HttpURLConnection conn = (HttpURLConnection) myUrl.openConnection();
			is = conn.getInputStream();
		}

		InputStreamReader isr = new InputStreamReader(is);
		BufferedReader br = new BufferedReader(isr);

		String inputLine;
		Gson gson;
		Identifier identifier;
		JSONArray jsonArray;
		JSONObject o;
		List<Identifier> identifiers = new ArrayList<Identifier>();
		while ((inputLine = br.readLine()) != null) {
			System.out.println(inputLine);
			gson = new Gson();

			jsonArray = new JSONArray(inputLine);

			for (Object object : jsonArray) {
				o = (JSONObject) object;
				identifier = gson.fromJson(o.toString(), Identifier.class);
				identifiers.add(identifier);
			}
		}
		br.close();
		for (Identifier id1 : identifiers) {
			System.out.println(id1.toString());
		}
		return identifiers;

	}

	/**
	 * Méthode de retour de la liste des Items du repository selon les
	 * Identifiers de la requête
	 * 
	 * @param agency
	 * @param idParent
	 * @param version
	 * @return
	 * @throws IOException
	 */
	private void getListItemsByIdentifiers(List<Identifier> identifiers) throws IOException {
		String httpsURL = basePath + "/api/v1/item/_getListLatest" + "?api_key=" + apiKey;
		URL myUrl = new URL(httpsURL);
		HttpURLConnection conn = null;
		if (myUrl.toString().contains("https")) {
			// TODO: Décommenter pour utiliser le HTTPS
			// HttpsURLConnection conn = (HttpsURLConnection)
			// myUrl.openConnection();

		} else {
			conn = (HttpURLConnection) myUrl.openConnection();

		}
		conn.setDoOutput(true);
		conn.setDoInput(true);
		conn.setRequestProperty("Content-Type", "application/json");
		conn.setRequestProperty("Accept", "application/json");
		conn.setRequestMethod("POST");

		OutputStreamWriter wr = new OutputStreamWriter(conn.getOutputStream());

		JSONObject jsonArray = new JSONObject();
		String str;
		jsonArray.put("Identifiers", identifiers.toArray());
		str = jsonArray.toString();
		// Changement des attributs du Json
		str = str.replaceAll("item1", "Identifier");
		str = str.replaceAll("item2", "Version");
		str = str.replaceAll("item3", "AgencyId");
		wr.write(str);
		wr.flush();

		StringBuilder sb = new StringBuilder();
		int HttpResult = conn.getResponseCode();
		if (HttpResult == HttpURLConnection.HTTP_OK) {
			BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream(), "utf-8"));
			String line = null;
			while ((line = br.readLine()) != null) {
				sb.append(line + "\n");
			}
			br.close();
			System.out.println(sb.toString());
		} else {
			System.out.println(conn.getResponseMessage());
		}
	}

	/**
	 * Méthode de retour de la liste des Items du repository pour un type
	 * spécifique
	 * 
	 * @param parentID
	 * @param itemType
	 * @param agencyId
	 * @param version
	 * @throws IOException
	 */
	private String getSetsByItemType(String parentID, String itemType, String agencyId, String version)
			throws IOException {
		String httpsURL = basePath + "/api/v1/_query" + "?api_key=" + apiKey;
		URL myUrl = new URL(httpsURL);
		HttpURLConnection conn = null;
		if (myUrl.toString().contains("https")) {
			// TODO: Décommenter pour utiliser le HTTPS
			// HttpsURLConnection conn = (HttpsURLConnection)
			// myUrl.openConnection();

		} else {
			conn = (HttpURLConnection) myUrl.openConnection();

		}
		conn.setDoOutput(true);
		conn.setDoInput(true);
		conn.setRequestProperty("Content-Type", "application/json");
		conn.setRequestProperty("Accept", "application/json");
		conn.setRequestMethod("POST");

		OutputStreamWriter wr = new OutputStreamWriter(conn.getOutputStream());
		// Renseignement de l'ItemType
		HashMap<String, String> ids = new HashMap<String, String>();
		ids.put("", itemType);

		JSONObject jsonArray = new JSONObject();
		String str;

		jsonArray.put("ItemTypes", ids.values());
		// Renseignement de l'agencyId, Version et id du rootItem
		ids = new HashMap<String, String>();
		ids.put("AgencyId", agencyId);
		ids.put("Identifier", parentID);
		ids.put("Version", version);
		List<Map<String, String>> array = new ArrayList<Map<String, String>>();
		array.add(ids);
		// Ajout des propriétés requises (une correction sera effective sur la
		// V2
		jsonArray.put("SearchSets", array.toArray());
		jsonArray.put("Cultures", new ArrayList<>());
		jsonArray.put("LanguageSortOrder", new ArrayList<>());
		jsonArray.put("SearchTerms", new ArrayList<>());
		jsonArray.put("SearchTargets", new ArrayList<>());
		str = jsonArray.toString();

		System.out.println(jsonArray);
		wr.write(str);
		wr.flush();
		StringBuilder sb = new StringBuilder();
		int HttpResult = conn.getResponseCode();
		if (HttpResult == HttpURLConnection.HTTP_OK) {
			BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream(), "utf-8"));
			String line = null;
			while ((line = br.readLine()) != null) {
				sb.append(line + "\n");
			}
			br.close();
			System.out.println(sb.toString());
		} else {
			str = conn.getResponseMessage();
		}
		return str;
	}

	/**
	 * Méthode création d'un évenement (logger)dans le repository
	 */
	private void NewEvent() throws IOException {
		String httpsURL = basePath + "/api/v1/event" + "?api_key=" + apiKey;
		URL myUrl = new URL(httpsURL);
		HttpURLConnection conn = null;
		if (myUrl.toString().contains("https")) {
			// TODO: Décommenter pour utiliser le HTTPS
			// HttpsURLConnection conn = (HttpsURLConnection)
			// myUrl.openConnection();

		} else {
			conn = (HttpURLConnection) myUrl.openConnection();

		}
		conn.setDoOutput(true);
		conn.setDoInput(true);
		conn.setRequestProperty("Content-Type", "application/json");
		conn.setRequestProperty("Accept", "application/json");
		conn.setRequestMethod("POST");

		OutputStreamWriter wr = new OutputStreamWriter(conn.getOutputStream());
		JSONObject jsonObject;
		jsonObject = new JSONObject();
		// TODO: remplacer par DateTime.now();
		jsonObject.put("logged", "2017-09-11T13:53:23.863Z");
		jsonObject.put("Application", "colectica.portal");
		jsonObject.put("Level", "1");
		jsonObject.put("Number", "2");
		jsonObject.put("Version", "1");
		jsonObject.put("Username", "anonymous");
		jsonObject.put("EventData", "test");
		jsonObject.put("ItemId", "52c5dd34-1b5f-460b-8904-6f0f2897f6a1");
		jsonObject.put("ItemAgencyId", "int.example");
		jsonObject.put("ItemVersion", "1");

		System.out.println(jsonObject);
		String str = jsonObject.toString();
		wr.write(str);
		wr.flush();
		StringBuilder sb = new StringBuilder();
		int HttpResult = conn.getResponseCode();
		if (HttpResult == HttpURLConnection.HTTP_OK) {
			BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream(), "utf-8"));
			String line = null;
			while ((line = br.readLine()) != null) {
				sb.append(line + "\n");
			}
			br.close();
			System.out.println(sb.toString());
		} else {
			System.out.println(conn.getResponseMessage());
		}

	}

	// {
	// "Items": [
	// {
	// "ItemType": "7E47C269-BCAB-40F7-A778-AF7BBC4E3D00",
	// "AgencyId": "int.example",
	// "Version": 0,
	// "Identifier": "f1e672e3-2c5d-4c4c-b9d5-a18fc4d1bc16",
	// "Item": "<Fragment xmlns:r=\"ddi:reusable:3_2\"
	// xmlns=\"ddi:instance:3_2\"> <Category isUniversallyUnique=\"true\"
	// versionDate=\"2015-11-16T21:18:04.5513144Z\" isMissing=\"false\"
	// xmlns=\"ddi:logicalproduct:3_2\">
	// <r:URN>urn:ddi:int.example:f1e672e3-2c5d-4c4c-b9d5-a18fc4d1bc16:1</r:URN>
	// <r:Agency>int.example</r:Agency>
	// <r:ID>f1e672e3-2c5d-4c4c-b9d5-a18fc4d1bc16</r:ID>
	// <r:Version>1</r:Version>
	// <r:VersionResponsibility>test</r:VersionResponsibility> <r:Label>
	// <r:Content xml:lang=\"en-US\">Sample Category</r:Content> </r:Label>
	// </Category> </Fragment>",
	// "Notes": [],
	// "VersionDate": "2017-09-11",
	// "VersionResponsibility": "test",
	// "IsPublished": true,
	// "IsDeprecated": false,
	// "IsProvisional": false,
	// "ItemFormat": "c0ca1bd4-1839-4233-a5b5-906da0302b89"
	// }
	// ],
	// "Options": {
	// }
	// }
	private void NewItem(String itemType, String agencyId, Long version, String XMLFragementItem,
			String versionDate, String versionResponsibility, boolean isPublished, Boolean isDeprecated,
			Boolean isProvisional, String itemFormat) throws IOException {
		String httpsURL = basePath + "/api/v1/item" + "?api_key=" + apiKey;
		URL myUrl = new URL(httpsURL);
		HttpURLConnection conn = null;
		if (myUrl.toString().contains("https")) {
			// TODO: Décommenter pour utiliser le HTTPS
			// HttpsURLConnection conn = (HttpsURLConnection)
			// myUrl.openConnection();

		} else {
			conn = (HttpURLConnection) myUrl.openConnection();

		}
		conn.setDoOutput(true);
		conn.setDoInput(true);
		conn.setRequestProperty("Content-Type", "application/json");
		conn.setRequestProperty("Accept", "application/json");
		conn.setRequestMethod("POST");

		OutputStreamWriter wr = new OutputStreamWriter(conn.getOutputStream());
		JSONObject jsonObject, values;
		jsonObject = new JSONObject();
		JSONArray jsonArray = new JSONArray();
		values = new JSONObject();
		values.put("ItemType", itemType);
		values.put("AgencyId", agencyId);
		values.put("Version", version);
		values.put("Identifier", UUID.randomUUID().toString());
		values.put("Item", XMLFragementItem);
		values.put("Notes", "[]");
		values.put("VersionDate", versionDate);
		values.put("VersionResponsibility", versionResponsibility);
		values.put("IsPublished", isPublished);
		values.put("IsDeprecated", isDeprecated);
		values.put("IsProvisional", isProvisional);
		values.put("ItemFormat", itemFormat);
		jsonObject.append("Items", values);
		String str = jsonObject.toString();

		System.out.println(jsonObject);
		
		
//		wr.write(str);
//		wr.flush();
//		StringBuilder sb = new StringBuilder();
//		int HttpResult = conn.getResponseCode();
//		if (HttpResult == HttpURLConnection.HTTP_OK) {
//			BufferedReader br = new BufferedReader(new InputStreamReader(conn.getInputStream(), "utf-8"));
//			String line = null;
//			while ((line = br.readLine()) != null) {
//				sb.append(line + "\n");
//			}
//			br.close();
//			System.out.println(sb.toString());
//		} else {
//			System.out.println(conn.getResponseMessage());
//		}

	}

}
