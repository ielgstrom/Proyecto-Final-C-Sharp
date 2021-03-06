<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Proyecto_Final_C_Sharp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
     .contact {
        margin-top: auto;
        margin-bottom: auto;
        width: 100%;
        height: 91.6vh;
        position: relative;
        padding: 10px;
        display: flex;
        justify-content: center;
        align-items: center;

        /* opacity: 0.5; */
    }

    .contact::before {
        content: "";
        background-image: url("/Imagenes/contact.jpg");
        background-size: auto !important;
        background-repeat: no-repeat;
        background-size: cover !important;
        position: absolute;
        top: 0px;
        right: 0px;
        bottom: 0px;
        left: 0px;
        opacity: 0.25;
        z-index: -1;
        height: calc(100vh - 50px);
    }

    .elemCenter2 {
        padding-left: 60px;
        border-left-style: solid;
        border-left-color: gray;
        border-left-width: 2px;
        opacity: 1;
    }

    .elemCenter {
        margin-right: 40px;
        opacity: 1;
    }

    </style>
     <div class="container-fluid contact">
        <div class="row  m-5">
            <div class="col-md-5 elemCenter">
                <div class="rowCon">
                    <h2 class="col-md-12 text-center">Contacto</h2>
                        <div class="form-group mb-3">
                          <label for="Name">Nombre</label>
                            <asp:TextBox ID="name" runat="server" CssClass="form-control" ToolTip="Entra tu nombre"/>
                          <%--<input runat="server" type="text" class="form-control" id="nombre">--%>
                        </div>
                        <div class="form-group mb-3">
                          <label for="mail">Correo</label>
                          <asp:TextBox ID="email" runat="server" CssClass="form-control"/>
                          <%--<input runat="server" type="email" class="form-control" id="correo" >--%>
                        </div>
                        <div class="form-group mb-3">
                            <label for="txtDesc">Descripcion</label>
                            <asp:textbox ID="txtDesc" TextMode="multiline" CssClass="form-control" Columns="50" Rows="5" runat="server"/>
                            <%--<textarea runat="server" class="form-control" id="txtDesc" rows="3"></textarea>--%>
                        </div>
                        <asp:Button ID="btEnviarCorreos" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="btEnviarCorreo_Click" />                        
                </div>
            </div>
  
            <div class="col-md-6 elemCenter2">
                <div class="rowContact">
                    <h2 class="my-4 col-md-12 text-center">Nuestros datos de contacto</h2>
                    <h3 class="col-md-12 text-left">Mail de centro</h3>
                    <p>Carrer d'En Llàstics, 2, 08003 Barcelona</p>
                    <h3 class="col-md-12 text-left">Dirección</h3>
                    <p>learnify.help@gmail.com</p>
                    <h3 class="col-md-12 text-left">Teléfono</h3>
                    <p>(+34) 671-408-611</p>
                </div>
            </div>
        </div>
    </div>    
</asp:Content>
