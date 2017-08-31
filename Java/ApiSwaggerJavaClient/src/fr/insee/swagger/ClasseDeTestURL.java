package fr.insee.swagger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

import javax.net.ssl.HttpsURLConnection;
import org.json.JSONArray;
import org.json.JSONObject;

import com.google.gson.Gson;

public class ClasseDeTestURL {
	// TODO: Mettre la configuration appropriée
	private static String basePath = "http://localhost:5000";
	private static String apiKey = "ADMINKEY";

	public static void main(String[] args) throws IOException {
		String agency = "int.example";
		String version = "1";
		String idParent = "52c5dd34-1b5f-460b-8904-6f0f2897f6a1";

		List<Identifier> ids = getSetsByAgencyIdVersion(agency, idParent, version);
		getListItemsByIdentifiers(ids);

	}

	public static List<Identifier> getSetsByAgencyIdVersion(String agency, String idParent, String version)
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

	public static void getListItemsByIdentifiers(List<Identifier> identifiers) throws IOException {
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

}
