package controllers;

import java.io.File;
import java.io.FileReader;

import libs.json.JSONArray;
import libs.json.JSONObject;
import libs.json.parser.JSONParser;

public class FileRead {
	public JSONArray sideBarLinks() {		
		
		JSONArray listJson = new JSONArray();
		JSONObject itemJson = new JSONObject();
		
		itemJson.put("icon", "home");
		itemJson.put("title", "Home");
		itemJson.put("link", "#");

		listJson.put(itemJson);

		
		return listJson;
	}
}

/*
 * [
    {
        "icon": "home",
        "title": "Home",
        "link": "#"
    },
    {
        "icon": "calendar",
        "title": "Calendário",
        "link": "#"
    },
    {
        "icon": "message",
        "title": "Chat",
        "link": "#"
    },
    {
        "icon": "patients",
        "title": "Pacientes",
        "link": "#"
    },
    {
        "icon": "masks",
        "title": "Dentistas",
        "link": "#"
    },
    {
        "icon": "suitcase",
        "title": "Funcionários",
        "link": "#"
    },
    {
        "icon": "search_file",
        "title": "Procedimentos",
        "link": "#"
    },
    {
        "icon": "search_file",
        "title": "Configurações",
        "link": "#"
    }
]
 * */