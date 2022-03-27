package mock;

public class MockJson {

	private static String sideBarLinks = "[{\"icon\":\"home\",\"title\":\"Home\",\"link\":\"index.jsp\"},{\"icon\":\"calendar\",\"title\":\"Calendário\",\"link\":\"calendar.jsp\"},{\"icon\":\"message\",\"title\":\"Chat\",\"link\":\"#\"},{\"icon\":\"patients\",\"title\":\"Pacientes\",\"link\":\"search/patient.jsp\"},{\"icon\":\"masks\",\"title\":\"Dentistas\",\"link\":\"search/dentist.jsp\"},{\"icon\":\"suitcase\",\"title\":\"Funcionários\",\"link\":\"search/employee.jsp\"},{\"icon\":\"search_file\",\"title\":\"Procedimentos\",\"link\":\"search/procedure.jsp\"},{\"icon\":\"settings\",\"title\":\"Configurações\",\"link\":\"#\"}]";

	public static String getSideBarLinks() {
		return sideBarLinks;
	}	
}
