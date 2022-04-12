<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaInicial.aspx.cs" Inherits="Proyecto_Final_C_Sharp.PantallaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body class="bodyPrincipal">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
        <div class="navbar navbar-fixed-top">
            <div class="container" style="margin-right: 20px">
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a runat="server" href="~/About.aspx" style="color: white; font-family: 'Open Sans'">Sobre nosotros</a></li>
                        <li><a runat="server" href="~/Contact.aspx" style="color: white; font-family: 'Open Sans'">Contacto</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div>
            <img class="logoPrincipal" src="/Imagenes/iconoApp.png" alt="Learnify"/>
        </div>
        <div>
            <label class="tituloPrincipal">LEARNIFY</label><br />
            <label class="eslogan">LEARN FROM YOUR HOME, EVERYWHERE</label>
        </div>
        <div class="botonesPrincipal">
            <button type="button" class="btn btn-dark" id="btnRegistro" onclick="/Registro.aspx">REGISTRO</button>
            <button type="button" class="btn btn-primary" id="btnEntrar" onclick="/Login.aspx">ENTRAR</button>
        </div>
    </form>
</body>
</html>
