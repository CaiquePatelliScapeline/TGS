<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="controllers.*, entities.*" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <!-- Authors -->
        <meta name="author" content="Caique Patelli Scapeline"/>
        <meta name="author" content="Gianluca Dias De Micheli"/>
        <meta name="author" content="Miriam Zequini"/>
        <meta name="author" content="Murilo Gustavo Schali da Costa"/>

        <title>TGS | Home</title>

        <!-- Shortcut Icon -->
        <link rel="shortcut icon" href="assets/icons/logo_bg.svg"/>

        <!-- Custom CSS -->
        <link href="assets/css/styles.css" rel="stylesheet"/>
        <link href="assets/css/customStyles.css" rel="stylesheet"/>

        <!-- Font Awesome -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="bg-body bg-info">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header text-center">
                                    	<img src="assets/img/logo.png" class="mt-4" height="100px"/>
                                    	<h3 class="text-center font-weight-light">Login</h3>
                                    </div>
                                    <div class="card-body">
                                        <form>
                                            <div class="form-floating mb-3">
                                                <input class="form-control" id="inputEmail" type="email" placeholder="name@example.com" />
                                                <label for="inputEmail">Usuário</label>
                                            </div>
                                            <div class="form-floating mb-3">
                                                <input class="form-control" id="inputPassword" type="password" placeholder="Password" />
                                                <label for="inputPassword">Senha</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <a class="small" href="password.html"></a>
                                                <a class="btn btn-primary" href="index.jsp">Login</a>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
        
        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>

        <!-- Custom JS -->
        <script src="assets/js/scripts.js"></script>
    </body>
</html>
