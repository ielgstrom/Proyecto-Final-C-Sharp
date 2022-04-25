<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Proyecto_Final_C_Sharp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .profilePic{
            height: 200px;
            border-radius: 12%;
        }
    </style>
    <h2><%: Title %></h2>
    <h3>Aqui estamos todos los creadores de esta pagina</h3>

    <br />
    <div class="row">
        <div class="col-md-3">
            <center><h4>Nombre y apellidos</h4> <br />
            <img src="" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Algo sobre cada uno</p> <br />
            <a href=""><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
        <div class="col-md-3">
            <center><h4>Nombre y apellidos</h4> <br />
            <img src="" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Algo sobre cada uno</p> <br />
            <a href=""><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
        <div class="col-md-3">
            <center><h4>Ignasi Elgström Puyuelo</h4> <br />
            <img src="Imagenes/foto_ignasi.jpeg" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Soy un fisico especializado en programacion web, con conocimiento en teconologias, de C#, JS, React, Node entre otros. Me defino por mi inquietud por aprender y mis ganas de automejora</p> <br />
            <a href="https://es.linkedin.com/in/ignasi-elgstr%C3%B6m"><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
        <div class="col-md-3">
            <center><h4>Miquel Sanuy Trullàs</h4> <br />
            <img src="./Imagenes/foto_msanuyt.jpg" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Algo sobre cada uno: aqui ira un texto que aun no me he pensado</p> <br />
            <a href="https://www.linkedin.com/in/msanuyt/"><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
    </div>
</asp:Content>
