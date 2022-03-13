package controllers;

import libs.json.JSONArray;
import libs.json.JSONObject;

public class FileRead {
	public JSONArray toJson() {
		
		JSONObject json1 = new JSONObject();
		json1.put("icon", "home");
		json1.put("title", "Home");
		json1.put("link", "#");
		JSONObject json2 = new JSONObject();
		json2.put("icon", "calendar");
		json2.put("title", "Calendário");
		json2.put("link", "#");
		JSONObject json3 = new JSONObject();
		json3.put("icon", "message");
		json3.put("title", "Chat");
		json3.put("link", "#");
		
		JSONArray listJson = new JSONArray();
		listJson.put(json1);
		listJson.put(json2);
		listJson.put(json3);
		return listJson;
	}
}
