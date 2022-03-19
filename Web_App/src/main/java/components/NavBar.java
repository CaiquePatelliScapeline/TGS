package components;

public class NavBar {	
	public String toString() {
		return "<nav class=\"sb-topnav navbar navbar-expand navbar-dark\">\r\n"
			 + "  <!-- Navbar Brand-->\r\n"
			 + "  <a class=\"navbar-brand ps-3\" href=\"index.html\">\r\n"
			 + "    <img src=\"assets/img/name_logo.svg\" height=\"50\">\r\n"
			 + "  </a>\r\n"
			 + "  <!-- Sidebar Toggle-->\r\n"
			 + "  <button class=\"btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0\" id=\"sidebarToggle\" href=\"#!\"><i class=\"fas fa-bars\"></i></button>\r\n"
			 + "  <!-- Workaround-->\r\n"
			 + "  <div class=\"d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0\"></div>\r\n"
			 + "  <!-- Navbar-->\r\n"
			 + "  <ul class=\"navbar-nav ms-auto ms-md-0 me-3 me-lg-4\">\r\n"
			 + "    <li class=\"nav-item dropdown\">\r\n"
			 + "      <a class=\"nav-link dropdown-toggle\" id=\"navbarDropdown\" href=\"#\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"><i class=\"fas fa-user fa-fw\"></i></a>\r\n"
			 + "      <ul class=\"dropdown-menu dropdown-menu-end\" aria-labelledby=\"navbarDropdown\">\r\n"
			 + "        <li><a class=\"dropdown-item\" href=\"#!\">Settings</a></li>\r\n"
			 + "        <li><a class=\"dropdown-item\" href=\"#!\">Activity Log</a></li>\r\n"
			 + "        <li><hr class=\"dropdown-divider\" /></li>\r\n"
			 + "        <li><a class=\"dropdown-item\" href=\"#!\">Logout</a></li>\r\n"
			 + "      </ul>\r\n"
			 + "    </li>\r\n"
			 + "  </ul>\r\n"
			 + "</nav>";
	}
}
