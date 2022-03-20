<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="components.*, controllers.*, entities.*" %>

<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <!-- Authors -->
        <meta name="author" content="Caique Patelli Scapeline"/>
        <meta name="author" content="Gianluca Dias De Micheli"/>

        <title>TGS | Calendar</title>

        <!-- Shortcut Icon -->
        <link rel="shortcut icon" href="assets/icons/logo_bg.svg"/>

        <!-- DataTables -->
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet"/>

        <!-- Custom CSS -->
        <link href="assets/css/styles.css" rel="stylesheet"/>
        <link href="assets/css/customStyles.css" rel="stylesheet"/>

        <!-- Font Awesome -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <%
			NavBar navBar = new NavBar();
			out.print(navBar);		
		%>
        <div id="layoutSidenav">
            <%
            	FileRead fileRead = new FileRead();                       	
				SideBar sideBar = new SideBar(fileRead.getJSONArray("sidebar"));
				out.print(sideBar);
			%>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Calendário</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active">Dashboard</li>
                        </ol>
                        <div class="row" style="margin-bottom: 12px">
                            <div class="btn-toolbar justify-content-around" role="toolbar" aria-label="Toolbar with button groups">						
							    <div class="btn-group" role="group">
								    <button id="btnGroupDrop1" type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
								    	Dropdown
								    </button>
								    <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
								    	<a class="dropdown-item" href="#">Dropdown link</a>
								    	<a class="dropdown-item" href="#">Dropdown link</a>
									</div>
								</div>
								
								<div class="input-group">
								    <input type="text" class="form-control" placeholder="__/__/____" aria-label="Input group example" aria-describedby="btnGroupAddon">
								    <div class="input-group-prepend">
								    	<div class="input-group-text btn-primary" style="height: 100%" id="btnGroupAddon"><img src="assets/icons/calendar.svg" height="25px" /></div>
								    </div>
								</div>
							    
							    <a href="#" class="btn btn-primary btn-lg" role="button" aria-pressed="true"><img src="assets/icons/add.svg" height="30px" class="mr-8"/>Abrir Agenda</a>
							    <a href="#" class="btn btn-primary btn-lg" role="button" aria-pressed="true"><img src="assets/icons/add.svg" height="30px" class="mr-8"/>Marcar Consulta</a>							  
							</div>
                        </div>
                        
                        <% 
                        	Table table = new Table("Próximas Consultas");
                        	out.print(table);
                        %>
                    </div>
                </main>                
            </div>
        </div>

        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>

        <!-- Custom JS -->
        <script src="assets/js/scripts.js"></script>

        <!-- Chart -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="assets/demo/chart-area-demo.js"></script>
        <script src="assets/demo/chart-bar-demo.js"></script>

        <!-- DataTables -->
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@latest" crossorigin="anonymous"></script>
        <script src="assets/js/datatables-simple-demo.js"></script>        
    </body>
</html>