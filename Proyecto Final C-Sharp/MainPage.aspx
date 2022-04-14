<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" MasterPageFile="~/NestedMasterPage1.master" Inherits="Proyecto_Final_C_Sharp.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <h1>Bienvenido, usuario</h1>
    <h2>Aqui tienes contenido que te puede interesar</h2>
    <h3>Foros que te pueden interesar</h3>
    <div class="HomePageForum">Primero</div>
    <div class="HomePageForum">Second</div>
    <div class="HomePageForum">h</div>
     <div class="HomePageForum">Second</div>
    <div class="HomePageForum">h</div>
    <h3>Podcasts que te pueden interesar</h3>
    <div class="HomePageForum">Second</div>
    <div class="HomePageForum">h</div>
     <div class="HomePageForum">Second</div>
    <div class="HomePageForum">h</div>
       
    <style>
        .HomePageForum{
            border-radius:8px;
            
            background-color:#2f52c3;
            display:inline-flex;
            margin:0 5px;
            height:130px;
            width:130px;
            opacity:0.8;
            color:white;
            transition: 0.3s;
        }
        .HomePageForum:hover{
            opacity:1;
        }
    </style>
</asp:Content>
