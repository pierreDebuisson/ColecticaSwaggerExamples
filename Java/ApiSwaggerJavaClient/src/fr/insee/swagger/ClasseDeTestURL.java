package fr.insee.swagger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;


public class ClasseDeTestURL {
	private static String basePath = "http://localhost:5000";
	private static String apiKey = "ADMINKEY";
	
	public static void main(String[] args) throws IOException
	{
		String agency = "int.example";
		String version = "1";
		String id = "52c5dd34-1b5f-460b-8904-6f0f2897f6a1";
		getSetsByAgencyIdVersion(agency,id,version);
	
	}
	
	public static void getSetsByAgencyIdVersion(String agency, String id, String version) throws IOException
	{
		String httpsURL = basePath+"/api/v1/set/"+agency+"/"+id+"/"+version+"?api_key="+apiKey;
	    URL myUrl = new URL(httpsURL);
	    java.io.InputStream is;
	    if(myUrl.toString().contains("https"))
	    {
	    	HttpsURLConnection conn = (HttpsURLConnection)myUrl.openConnection();
	    	is = conn.getInputStream();
	    }
	    else
	    {
	    	HttpURLConnection	conn = (HttpURLConnection)myUrl.openConnection();
	    	is = conn.getInputStream();
	    }
	    
	    InputStreamReader isr = new InputStreamReader(is);
	    BufferedReader br = new BufferedReader(isr);

	    String inputLine;

	    while ((inputLine = br.readLine()) != null) {
	        System.out.println(inputLine);
	    }

	    br.close();
	}
}


