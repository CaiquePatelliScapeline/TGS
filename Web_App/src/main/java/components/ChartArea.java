package components;

public class ChartArea {

	public String toString() {
		return "<div class=\"col-xl-12\">\r\n"
			 + "  <div class=\"card mb-4\">\r\n"
			 + "    <div class=\"card-header\">\r\n"
			 + "      <i class=\"fas fa-chart-area me-1\"></i>\r\n"
			 + "      Area Chart Example\r\n"
			 + "    </div>\r\n"
			 + "    <div class=\"card-body\"><canvas id=\"myAreaChart\" width=\"100%\" height=\"40\"></canvas></div>\r\n"
			 + "  </div>\r\n"
			 + "</div>";
	}
}
