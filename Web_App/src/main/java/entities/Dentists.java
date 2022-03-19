package entities;

import libs.json.JSONArray;
import libs.json.JSONTokener;

public class Dentists {

	private static JSONArray dentists = (JSONArray) new JSONTokener("[{\"nome\":\"Roberto Lakhross\"},{\"nome\":\"Roberto Lakhross\"}]").nextValue();
	
	public static JSONArray getDentists() {
		return dentists;
	}
	
}
