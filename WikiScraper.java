package com.packtpub.JavaScraping.SimpleScraper;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;

import java.net.*;
import java.io.*;

public class WikiScraper {

	public static void main(String[] args) {
		// TODO 
		
		scrapeTopic("/Upper_Cliffs");	
	
	}

	public static void scrapeTopic(String url) {
		String html = getUrl("http://wiki.climbing.ie/index.php"+url);
		Document doc = Jsoup.parse(html);
		String contentText = doc.select("#mw-content-text > p").first().text();
		
		System.out.println(contentText);
		
	}
	
	public static String getUrl(String url){
		URL urlObj = null;
		try{
			urlObj = new URL(url);
		}
		catch (MalformedURLException e){ //Look up exception name
			System.out.println("The url was malformed");
			return "";
		}
		
		URLConnection urlCon = null;
		BufferedReader in = null;
		String outputText = "";
		
		try{
			urlCon = urlObj.openConnection();
			in = new BufferedReader(new InputStreamReader(urlCon.getInputStream()));
			String line = "";
			while((line = in.readLine()) != null){ //Read a new line into variable line while there is still something to read
				outputText += line; //add line read in to the string outputText. 
			}
			in.close();//Close connection to URL
		} catch(IOException e){
			System.out.println("There was an error connecting to the URL");
			return "";
		}
		return outputText;
	}
}









