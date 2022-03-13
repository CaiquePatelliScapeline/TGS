package components;

public class Report {
	
	public Report(String icon, String title, String value) {
		this.icon = icon;
		this.title = title;
		this.value = value;
	}
	
	private String icon;
	private String title;
	private String value;
	
	public String toString() {		
		
		return "<div class=\"col-xl-2 col-md-6\">\r\n"
			 + "  <div class=\"card text-center text-white mb-3 report\">\r\n"
			 + "    <div class=\"card-body\">\r\n"
			 + "      <h5 class=\"card-title\">\r\n"
			 + "        <img src=\"assets/icons/" + this.icon + ".svg\" width=\"50px\" height=\"50px\"/>\r\n"
			 + "        " + this.title + "\r\n"
			 + "      </h5>\r\n"
			 + "      <p class=\"card-text\">" + this.value + "</p>\r\n"
			 + "    </div>\r\n"
			 + "  </div>\r\n"
			 + "</div>";
	}
}
