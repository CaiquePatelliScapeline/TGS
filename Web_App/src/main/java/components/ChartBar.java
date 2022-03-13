package components;

public class ChartBar {

	public String toString() {
		return "<div class=\"col-xl-6\">\r\n"
			 + "  <div class=\"card mb-4\">\r\n"
			 + "    <div class=\"card-header\">\r\n"
			 + "      <i class=\"fas fa-chart-bar me-1\"></i>\r\n"
			 + "      Bar Chart Example\r\n"
			 + "    </div>\r\n"
			 + "    <div class=\"card-body\"><canvas id=\"myBarChart\" width=\"100%\" height=\"40\"></canvas></div>\r\n"
			 + "  </div>\r\n"
			 + "</div>";
	}
}
