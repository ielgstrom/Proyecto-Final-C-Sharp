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
                <label runat="server" id="subtextoSignUp">
                    ¿No tienes cuenta?
                    <a runat="server" href="~/RegisterPage.aspx">Crea una</a>
                </label>
                <hr />
            </div>
            <form class="formRegistro" runat="server">
              <div class="form-group">
                <label for="inputEmail">Usuario</label>
                <input type="text" class="form-control" id="IdUsername" placeholder="Escriba su usuario" runat="server"/>
              </div>
              <div class="form-group">
                <label for="inputContra">Contraseña</label>
                  <input runat="server" type="password" class="form-control" aria-describedby="contraHelp" id="inputContra" placeholder="********"/>
              </div>
              <div class="form-group form-check">
                <input type="checkbox" class="form-check-input" id="checkCookie" runat="server"/>
                <label class="form-check-label" for="connected">Recuerdame</label>
                 <br />
                <asp:Label runat="server" Text="" ID="mensajeError"></asp:Label>
              </div>
                <asp:Button ID="btIniciarSesion" runat="server" CssClass="brLoguear" Height="46px" OnClick="btIniciarSesion_Click" Text="INICIAR SESION" Width="125px" />
            </form>
          </div>
      </div>
    </div>
   <script src="Scripts/scripts.js"></script>
</body>
</html>