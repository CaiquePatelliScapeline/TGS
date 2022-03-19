package components;

public class Table {
	
	private String tableTitle;
	
	public Table(String tableTitle) {
		this.tableTitle = tableTitle;
	}

	public String toString() {
		return "<div class=\"card mb-4\">\r\n"
			 + "  <div class=\"card-header\">\r\n"
		 	 + "    <i class=\"fas fa-table me-1\"></i>\r\n"
			 + 		tableTitle
			 + "  </div>\r\n"
			 + "  <div class=\"card-body\">\r\n"
			 + "    <table id=\"datatablesSimple\">\r\n"
			 + "      <thead>\r\n"
			 + "        <tr>\r\n"
			 + "          <th>Name</th>\r\n"
			 + "          <th>Position</th>\r\n"
			 + "          <th>Office</th>\r\n"
			 + "          <th>Age</th>\r\n"
			 + "          <th>Start date</th>\r\n"
			 + "          <th>Salary</th>\r\n"
			 + "        </tr>\r\n"
			 + "      </thead>\r\n"
			 + "      <tfoot>\r\n"
			 + "        <tr>\r\n"
			 + "          <th>Name</th>\r\n"
			 + "          <th>Position</th>\r\n"
			 + "          <th>Office</th>\r\n"
			 + "          <th>Age</th>\r\n"
			 + "          <th>Start date</th>\r\n"
			 + "          <th>Salary</th>\r\n"
			 + "        </tr>\r\n"
			 + "      </tfoot>\r\n"
			 + "      <tbody>\r\n"
			 + "        <tr>\r\n"
			 + "          <td>Tiger Nixon</td>\r\n"
			 + "          <td>System Architect</td>\r\n"
			 + "          <td>Edinburgh</td>\r\n"
			 + "          <td>61</td>\r\n"
			 + "          <td>2011/04/25</td>\r\n"
			 + "          <td>$320,800</td>\r\n"
			 + "        </tr>\r\n"
			 + "      </tbody>\r\n"
			 + "    </table>\r\n"
			 + "  </div>\r\n"
			 + "</div>";
	}
}
