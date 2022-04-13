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

        .contenedorLogin {
            align-items: center;
            display: flex;
            justify-content: center;
            height: 100%;
            background-image: url(Imagenes/fondoPantalla.jpg);
            background-size: cover;
        }

        .elementoLogin {
            background: #666;
            height: 85%;
            width: 70%;
        }

        .columna1 {
            width: 50%;
            float: left;
            background: linear-gradient(to right, navy, steelblue);
            height: 100%;
            display: flex;
            align-items: center
        }

        .columna2 {
            width: 50%;
            float: right;
            height: 100%;
            background-color: white;
            font-family: 'HK Grotesk', sans-serif;
        }

        #tituloLogin {
            margin-bottom: 34%;
            margin-left: auto;
            margin-right: auto;
            color: white;
            font-size: 60px;
            font-family: 'HK Grotesk', sans-serif;
            font-weight: 800;
        }

        #imgLogin {
            position: absolute;
            margin: auto;
            top: 10%;
            left: 0;
            right: 34%;
            bottom: 0;
        }

        .formRegistro {
            margin-left: 25%;
        }

        #btSignUp {
            margin-left: 20%;
        }

        .tituloSignUp {
            text-align:center;
            margin-top: 7%;
        }

        #textoSignUp {
            font-size: 25px;
            color: #337ab7;
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

            <div class="tituloSignUp">
                <label id="textoSignUp">CREAR UNA CUENTA NUEVA</label>
                <br />
                <label id="subtextoSignUp">
                    Ya tienes una?
                    <a runat="server" href="~/LoginPage.aspx">Inicia Sesión</a>
                </label>
                <hr />
            </div>

            <form class="formRegistro">
              <div class="form-group">
                <label for="inputNombre">Nombre completo</label>
                <input type="email" class="form-control" id="inputNombre" placeholder="Nombre Apellido"/>
              </div>
              <div class="form-group">
                <label for="inputNombreUsuario">Nombre de Usuario</label>
                <input type="email" class="form-control" id="inputNombreUsuario" placeholder="Nombre Usuario"/>
              </div>
              <div class="form-group">
                <label for="inputEmail">Correo electrónico</label>
                <input type="email" class="form-control" id="inputEmail" placeholder="correo@gmail.com"/>
              </div>
              <div class="form-group">
                <label for="inputContra">Contraseña</label>
                <input type="password" class="form-control" aria-describedby="contraHelp" id="inputContra" placeholder="**********"/>
                <small id="contraHelp" class="form-text text-muted">Entra una contraseña que contenga letras, numeros y caracteres</small>
              </div>
              <div class="form-group">
                <label for="inputRepetirContra">Repite la contraseña</label>
                <input type="password" class="form-control" aria-describedby="rContraHelp" id="inputRepetirContra" placeholder="**********"/>
                <small id="rContraHelp" class="form-text text-muted">Las contraseñas deben de coincidir</small>
              </div>
              <div class="form-group form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1"/>
                <label class="form-check-label" for="exampleCheck1">
                    He leido y acepto la 
                    <a runat="server" href="#">Política de Privacidad</a>
                </label>
              </div>
              <button id="btSignUp" type="submit" class="btn btn-primary">REGISTRARSE</button>
            </form>
          </div>
      </div>
    </div>
</body>
</html>
