<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Proyecto_Final_C_Sharp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<webopt:bundlereference runat="server" path="~/Content" />
    <title></title>
    <style>
        body, html {
          height: 100%;
        }

        body {
          margin: 0;
          padding: 0;
        }
    </style>
</head>
<body>
     <div class="contenedorLogin">
      <div class="elementoLogin">
          <div class="columna1">
              <label id="tituloLogin">LEARNIFY</label>
              <img src="Imagenes/logoLernify.png" id="imgLogin" alt="Learnify" width="200" height="200"/>
          </div>
          <div class="columna2">

            <div class="tituloSignIn">
                <label id="textoSignIn">INICIAR SESIÓN</label>
                <br />
                <hr />
            </div>
            <form class="formRegistro">
              <div class="form-group">
                <label for="inputEmail">Correo electrónico</label>
                <input type="email" class="form-control" id="inputEmail" placeholder="correo@gmail.com"/>
              </div>
              <div class="form-group">
                <label for="inputContra">Contraseña</label>
                <input type="password" class="form-control" aria-describedby="contraHelp" id="inputContra" placeholder="**********"/>
              </div>
              <div class="form-group form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1"/>
                <label class="form-check-label" for="connected">Recuerdame</label>
              </div>
              <button id="btSignIn" type="submit" class="btn btn-primary">INICIAR SESIÓN</button>
            </form>
          </div>
      </div>
    </div>
</body>
</html>