<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/NestedMasterPage1.master" CodeBehind="Perfil.aspx.cs" Inherits="Proyecto_Final_C_Sharp.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
     <script src="Scripts/scripts.js"></script>

    <h1>Este es tu perfil: "Nombre"</h1>
        <img src="Imagenes/profileImageDefault.jpg" class="imageProfile"/>
    <div class="row mainProfileContent">
        
        <div class="col-md-6">
            <div class="elementmargin">
                <asp:Label Text="Nombre" runat="server" CssClass="ProfileInputText"/>
                <asp:TextBox runat="server" CssClass="textAreaProfileleft" ID="TextBoxName"/>
            </div>
            
            <div class="elementmargin">
            </div>
        </div>
        <div class="col-md-6">
            <div class="elementmargin">
                <asp:Label Text="Antigua Contraseña" runat="server" CssClass="ProfileInputText"/>
                <asp:TextBox runat="server" CssClass="textAreaProfileright" ID="TextBoxOldPassw"/>
            </div>
            
            <div class="elementmargin">
                <asp:Label Text="Nueva Contraseña" runat="server" CssClass="ProfileInputText"/>
                <asp:TextBox runat="server" CssClass="textAreaProfileright" ID="TextBoxNewPassw1"/>
            </div>
            
            <div class="elementmargin">
                <asp:Label Text="Repetir nueva Contraseña" runat="server" CssClass="ProfileInputText"/>
                <asp:TextBox runat="server" CssClass="textAreaProfileright" ID="TextBoxNewPassw2"/>
            </div>
            <div class="elementmargin">
                <asp:Label Text="" runat="server" ID="LabelError" /> <br />
                <asp:Label Text="" runat="server" ID="LabelError2" />
            </div>
    </div>
        </div>
    <div class="row mainProfileContent">
        <asp:Button ID="CloseSesion" runat="server" OnClientClick="deleteCookie();" hr Text="Cerrar Sesion" CssClass="btn btn-danger col-md-2" OnClick="CloseSesion_Click"/>
        <asp:Button ID="SaveChanges" runat="server" Text="Guardar Cambios" CssClass="btn btn-primary col-md-4 col-md-offset-6" OnClick="SaveChanges_Click"/>
    </div>
    <style>
        .imageProfile{
            border-radius: 70px;
            width: 140px;
            margin-left:70px;
            margin-top:20px;
        }
        .textAreaProfileleft{
            position:absolute;
            left:130px;
            height:30px;
        }
        .textAreaProfileright{
            position:absolute;
            left:330px;
            height:30px;
        }
        .elementmargin{
            margin: 10px 0;
        }
        .ProfileInputText{
            font-size:2.5rem;
        }
        .mainProfileContent{
            padding: 30px 70px;
                width: 1302px;
        }
    </style>
</asp:Content>
