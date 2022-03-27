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

        <title>TGS | Consultas</title>

        <!-- Shortcut Icon -->
        <link rel="shortcut icon" href="../assets/icons/logo_bg.svg"/>

        <!-- DataTables -->
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet"/>

        <!-- Custom CSS -->
        <link href="../assets/css/styles.css" rel="stylesheet"/>
        <link href="../assets/css/customStyles.css" rel="stylesheet"/>

        <!-- Font Awesome -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <%
			NavBar navBar = new NavBar();
        	navBar.setPath("../");
			out.print(navBar);		
		%>
        <div id="layoutSidenav">
            <%
            	FileRead fileRead = new FileRead();                       	
				SideBar sideBar = new SideBar(fileRead.getJSONArray("sidebar"));
				sideBar.setPath("../");
				out.print(sideBar);
			%>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Abrir Agenda</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active"></li>
                        </ol>
                                           
                       	<form>
	                        <div class="row align-items-center">								
							  	<div class="mb-3 col-3">
							    	<label for="Dentista" class="form-label">Dentista</label>
							    	<select class="form-select" aria-label="Select">
										<option selected></option>
										<option value="1">One</option>
										<option value="2">Two</option>
										<option value="3">Three</option>
									</select>	
							  	</div>
							  	<div class="mb-3 col-3">
							    	<label for="Duration" class="form-label">Duração da Consulta</label>
							    	<input type="time" class="form-control" id="duration" aria-describedby="duration">	
							  	</div>
							  	<div class="mb-3 col-3">
							    	<label for="BeginDate" class="form-label">Data Inicial</label>
							    	<input type="date" class="form-control" id="beginDate" aria-describedby="beginDate">	
							  	</div>	
							  	<div class="mb-3 col-3">
							    	<label for="EndDate" class="form-label">Data Final</label>
							    	<input type="date" class="form-control" id="endDate" aria-describedby="endDate">	
							  	</div>	
							  	<div class="mb-3 col-3">
							    	<label for="BeginWork" class="form-label">Inicio do Expediente</label>
							    	<input type="time" class="form-control" id="beginWork" aria-describedby="beginWork">	
							  	</div>
							  	<div class="mb-3 col-3">
							    	<label for="EndWork" class="form-label">Fim do Expediente</label>
							    	<input type="time" class="form-control" id="endWork" aria-describedby="endWork">	
							  	</div>
							  	<div class="mb-3 col-3">
							    	<label for="BeginLunch" class="form-label">Inicio do Almoço</label>
							    	<input type="time" class="form-control" id="beginWork" aria-describedby="beginWork">	
							  	</div>
							  	<div class="mb-3 col-3">
							    	<label for="EndLunch" class="form-label">Fim do Almoço</label>
							    	<input type="time" class="form-control" id="endLunch" aria-describedby="endLunch">	
							  	</div>
							  	
							  	
							  	<div class="col-12 btn-toolbar flex-row-reverse">
								  	<button type="submit" class="btn btn-primary">Criar</button>								  	
							  	</div>							  							
	                        </div>
						</form>
                    </div>
                </main>                
            </div>
        </div>

        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>

        <!-- Custom JS -->
        <script src="../assets/js/scripts.js"></script>

        <!-- Chart -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="../assets/demo/chart-area-demo.js"></script>
        <script src="../assets/demo/chart-bar-demo.js"></script>

        <!-- DataTables -->
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@latest" crossorigin="anonymous"></script>
        <script src="../assets/js/datatables-simple-demo.js"></script>        
    </body>
</html>