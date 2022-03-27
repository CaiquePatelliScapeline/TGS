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

        <title>TGS | Dentistas</title>

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
                        <h1 class="mt-4">Cadastrar Dentista</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active"></li>
                        </ol>
                                           
                       	<form>
	                        <div class="row align-items-center">
	                        	<h3>Dados Básicos</h3>
								
							  	<div class="mb-3 col-6">
							    	<label for="Cro" class="form-label">CRO</label>
							    	<input type="text" class="form-control" id="cro" aria-describedby="cro">	
							  	</div>
							  	<div class="mb-3 col-6">
							    	<label for="Name" class="form-label">Nome</label>
							    	<input type="text" class="form-control" id="name" aria-describedby="name">							    	
							  	</div>							  	
							  	<div class="mb-3 col-12">
							    	<label for="Expertise" class="form-label">Especialidade</label>
							    	<input type="text" class="form-control" id="expertise" aria-describedby="expertise">	
							  	</div>
							  	<div class="mb-3 col-6">
							    	<label for="Telephone" class="form-label">Telefone</label>
							    	<input type="text" class="form-control" id="telephone" aria-describedby="telephone">	
							  	</div>
							  	<div class="mb-3 col-6">
							    	<label for="Celphone" class="form-label">Celular</label>
							    	<input type="text" class="form-control" id="celphone" aria-describedby="celphone">	
							  	</div>	
							  	<div class="mb-3 col-6">
    								<label for="Email" class="form-label">Email</label>
    								<input type="email" class="form-control" id="email" aria-describedby="email">
  								</div>
  								<div class="mb-3 col-6">
    								<label for="Password" class="form-label">Senha</label>
    								<input type="password" class="form-control" id="password">
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