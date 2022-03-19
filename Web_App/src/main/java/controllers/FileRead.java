package controllers;

import mock.MockJson;
import libs.json.JSONArray;
import libs.json.JSONTokener;

public class FileRead {
	
	public JSONArray getJSONArray(String path) {		
		
		String strJSON = "";
		
		switch (path.toLowerCase()) {
			case "sidebar":
				strJSON = MockJson.getSideBarLinks();
			break;
		}

		JSONArray jArray = (JSONArray) new JSONTokener(strJSON).nextValue();
		
		return jArray;
	}
}