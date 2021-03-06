<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/NestedMasterPage1.master" CodeBehind="Foro.aspx.cs" Inherits="Proyecto_Final_C_Sharp.Foro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <div class="testingg">
        <div class="headerForum">
            <asp:Label ID="Label1" runat="server" CssClass="titleForo"></asp:Label>
        </div>
    </div>
    <div class="PageForChat">
        <asp:Panel CssClass="contentedorMensajes" ID="contenedorMensajesTest" runat="server"></asp:Panel>
        <%--MODELO PARA AÑADIR MENAJES DE MANERA DINAMICA EN C#
            <div class="contentedorMensajes" id="contenedorMensajes">
            <div class="mensajeIndividual mensajeIndividualOther">
                <small class="nameForumPerson">Nombre Persona</small> - <small class="dateForumPost">13:20 20/12/2021</small>
                <div class="messageContent">
                    Contenido mensaje
                </div>
            </div>
        </div>--%>
        <asp:Panel  ID="Panel1" runat="server" DefaultButton="Button1">
            <asp:TextBox ID="InputForo" autocomplete="off" runat="server" Enabled="true" CssClass="inputChat"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Publicar" CssClass="btn btn-secondary buttonChat" OnClick="Button1_Click" />
        </asp:Panel>
    </div>
    <style>
        .titleForo{
            font-size:3rem;
            font-weight:300;
        }
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
            color:black;
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
                margin-top: 15px;
        }
        .testingg{

            width: 100%;
        }
        .clasbuton{
             opacity:0.9;
        }
        .PageForChat{
            border: 1px solid black;
            
    width: calc(100vw - 345px);

            height: calc(100vh - 150px);
            position: relative;
            background: rgb(48 60 201 / 65%);
            border-radius: 10px;
        }

        .inputChat{
            position: absolute;
            top: 92%;
            left: 2%;
            width: 88%;
            max-width: 100%;
        }
        .buttonChat{
            position: absolute;
            padding: 3px;
            height: 25px;
            top: 92%;
            right: 2%;
            color:black;
        }
    </style>
</asp:Content>
