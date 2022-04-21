<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Proyecto_Final_C_Sharp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .profilePic{
            height: 200px;
            border-radius: 12%;
        }
    </style>
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
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
            <center><h4>Nombre y apellidos</h4> <br />
            <img src="" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Algo sobre cada uno</p> <br />
            <a href=""><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
        <div class="col-md-3">
            <center><h4>Miquel Sanuy Trullàs</h4> <br />
            <img src="./Imagenes/foto_msanuyt.jpg" alt="profilePic" class="profilePic"/> <br /><br />
            <p> Algo sobre cada uno: aqui ira un texto que aun no me he pensado</p> <br />
            <a href="https://www.linkedin.com/in/msanuyt/"><img src="./Imagenes/linkedInIcon.png" alt="linkedInIcon" style="width:50px;height:50px;"/></a></center>
        </div>
    </div>
</asp:Content>
