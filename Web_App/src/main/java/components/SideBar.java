package components;

import libs.json.*;

public class SideBar {
	
	public SideBar(JSONArray json) {
		this.json = json;
	}
	
	private JSONArray json;

	public String toString() {
	
		return "<div id=\"layoutSidenav_nav\">\r\n"
		 + "  <nav class=\"sb-sidenav accordion sb-sidenav-blue\" id=\"sidenavAccordion\">\r\n"
		 + "    <div class=\"sb-sidenav-menu\">\r\n"
		 + "      <div class=\"nav\">\r\n"
		 + "        <div class=\"sb-sidenav-menu-heading\"></div>\r\n"
		 + 			renderList()
		 + "      </div>\r\n"
		 + "    </div>\r\n"
		 + "  </nav>\r\n"
		 + "</div>";
	}
	
	private String renderList() {
		String list = "";
		
		for(int i = 0; i < json.length(); i++) {
			list += "<a class=\"nav-link\" href=\""+ json.getJSONObject(i).getString("link") +"\">\r\n"
				  + "  <div class=\"sb-nav-link-icon\"><img src=\"assets/icons/"+ json.getJSONObject(i).getString("icon") +".svg\" width=\"25px\" height=\"25px\"></div>\r\n"
				  + "  "+ json.getJSONObject(i).getString("title") +"\r\n"
				  + "</a>\r\n";
		}
		
		return list;
	}
}
