<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Proyecto_Final_C_Sharp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
        }

        .columna2 {
            width: 50%;
            float: right;
            height: 100%;
            background-color: white;
        }

        #imgLogin {
            position: absolute;
            margin: auto;
            top: 0;
            left: 24%;
            bottom: 0;
        }
    </style>
</head>
<body>
    <div class="contenedorLogin">
      <div class="elementoLogin">
          <div class="columna1">
                <img src="Imagenes/logoLernify.png" id="imgLogin" alt="Learnify" width="300" height="300"/>
          </div>
          <div class="columna2">
              
          </div>
      </div>
    </div>
</body>
</html>
