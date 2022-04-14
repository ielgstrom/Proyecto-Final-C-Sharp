<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Proyecto_Final_C_Sharp.Registro" %>

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
              <label runat="server" id="tituloLogin">LEARNIFY</label>
              <img runat="server" src="Imagenes/logoLernify.png" id="imgLogin" alt="Learnify" width="200" height="200"/>
          </div>
          <div class="columna2">

            <div class="tituloSignUp">
                <label runat="server" id="textoSignUp">CREAR UNA CUENTA NUEVA</label>
                <br />
                <label runat="server" id="subtextoSignUp">
                    Ya tienes una?
                    <a runat="server" href="~/LoginPage.aspx">Inicia Sesión</a>
                </label>
                <hr />
            </div>
              
            <form runat="server" class="formRegistro">
              <div class="form-group">
                <label runat="server" for="inputNombre">Nombre completo</label>
                <input runat="server" type="email" class="form-control" id="inputNombre" aria-describedby="errorNombre" placeholder="Nombre Apellido"/>
              </div>
              <div class="form-group">
                <label runat="server" for="inputNombreUsuario">Nombre de Usuario</label>
                <input runat="server" type="email" class="form-control" id="inputNombreUsuario" aria-describedby="errorNombreUsuario" placeholder="Nombre Usuario"/>
              </div>
              <div class="form-group">
                <label runat="server" for="inputEmail">Correo electrónico</label>
                <input runat="server" type="email" class="form-control" id="inputEmail" aria-describedby="errorEmail" placeholder="correo@gmail.com"/>
              </div>
              <div class="form-group">
                <label runat="server" for="inputContra">Contraseña</label>
                <input runat="server" type="password" class="form-control" aria-describedby="contraHelp" id="inputContra" placeholder="********"/>
                <small runat="server" id="contraHelp" class="form-text text-muted">Entra una contraseña que contenga letras, numeros y caracteres</small>
              </div>
              <div class="form-group">
                <label runat="server" for="inputRepetirContra">Repite la contraseña</label>
                <input runat="server" type="password" class="form-control" aria-describedby="rContraHelp" id="inputRepetirContra" placeholder="********"/>
                <small runat="server" id="rContraHelp" class="form-text text-muted">Las contraseñas deben de coincidir</small>
              </div>
              <div class="form-group form-check">
                <input runat="server" type="checkbox" class="form-check-input" id="inputPoliticaPrivacidad"/>
                <label runat="server" class="form-check-label" for="inputPoliticaPrivacidad">
                    He leido y acepto la 
                    <a runat="server" href="#">Política de Privacidad</a>
                </label><br />
                <asp:Label runat="server" Text="" ID="mensajeError"></asp:Label>
              </div>
                <asp:Button ID="btSignUp" runat="server" Text="REGISTRARSE" OnClick="btSignUp_Click"></asp:Button>
            </form>
          </div>
      </div>
    </div>
</body>
</html>
