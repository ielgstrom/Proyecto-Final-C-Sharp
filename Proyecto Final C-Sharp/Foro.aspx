<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/NestedMasterPage1.master" CodeBehind="Foro.aspx.cs" Inherits="Proyecto_Final_C_Sharp.Foro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <div class="testingg">
        <div class="headerForum">
            <h1>Nombre del foro</h1>
            <asp:Button ID="ButtonJoin" runat="server" Text="Unirse" OnClick="ButtonJoin_Click" BackColor="#8888f3" Height="30px" Width="120px" CssClass="btn btn-primary clasbuton" />
        </div>
    </div>
    <div class="PageForChat">
        <div class="contentedorMensajes">
            <div class="mensajeIndividual mensajeIndividualOther">
                <small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div>
            </div>
            <div class="mensajeIndividual mensajeIndividualUser"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualOther"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualUser"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualOther"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualOther"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualUser"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualOther"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
            <div class="mensajeIndividual mensajeIndividualOther"><small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">Contenido mensaje</div></div>
      
        </div>
        <asp:TextBox ID="InputForo" runat="server" Enabled="false" CssClass="inputChat"></asp:TextBox>
    </div>
    <style>
        .messageContent{
            font-size:1.7rem;
        }
        .nameForumPerson, .dateForumPost{
            font-size:75%
        }
        .contentedorMensajes{
             overflow-y: auto;
             height: 91%;
        }
        .mensajeIndividual{
            background: white;
            border: 1px solid black;
            width: 80%;
            padding: 8px;
            border-radius: 5px;
            margin-top: 7px;
            margin-bottom: 7px;
        }
        .mensajeIndividualOther{
            margin-right:auto;
            margin-left:5px;
        }
        .mensajeIndividualUser{ 
            margin-left:auto;
            margin-right:5px;
        }
        .headerForum{
            justify-content: space-between;
             display: inline-flex;
             width: 100%;
            align-items: flex-end;
        }
        .testingg{

            width: 100%;
        }
        .clasbuton{
             opacity:0.9;
        }
        .PageForChat{
            border: 1px solid black;
            width: 100%;
            height: calc(100vh - 150px);
            position: relative;
            background: rgb(48 60 201 / 65%);
            border-radius: 10px;
        }

        .inputChat{
            position: absolute;
            top: 93%;
            left: 2%;
            width: 96%;
            max-width: 100%;
        }
    </style>
</asp:Content>
