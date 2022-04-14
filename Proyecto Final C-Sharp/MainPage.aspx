<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" MasterPageFile="~/NestedMasterPage1.master" Inherits="Proyecto_Final_C_Sharp.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
   
    
    <h1>Bienvenido, usuario</h1>
    <h2>Aqui tienes contenido que te puede interesar</h2>
    <h3>Foros que te pueden interesar</h3>
    <div class="HomePageForum">
        <small>
        Titulo del programa
        </small>
    </div>
    <div class="HomePageForum">
        <small>
        Titulo del programa
        </small>
    </div>
    <div class="HomePageForum">
        <small>
        Otro foro
        </small>
    </div>
     <div class="HomePageForum">
         <small>
        Vaya foro
        </small>
     </div>
    <div class="HomePageForum">
        <small>
        Otro mas
        </small>
    </div>
    <h3>Podcasts que te pueden interesar</h3>
    <div class="HomePageForumplayer">
        <img src="Imagenes/icons8-play-60.png" />
        <small class="tituloPod">Nombre Podcast</small>
    </div>
    <div class="HomePageForumplayer">
        <img src="Imagenes/icons8-play-60.png" />
        <small class="tituloPod">Nombre Podcast</small></div>
     <div class="HomePageForumplayer">
         <img src="Imagenes/icons8-play-60.png" />
         <small class="tituloPod">Nombre Podcast</small>
     </div>
    <div class="HomePageForumplayer">
        <img src="Imagenes/icons8-play-60.png" />
        <small class="tituloPod">Nombre Podcast</small>
    </div>
 
     
    <style>
        .HomePageForum, .HomePageForumplayer{
            border-radius:8px;
            background-color:#2f52c3;
            display:inline-flex;
            margin:0 5px;
            height:130px;
            width:130px;
            opacity:0.8;
            color:white;
            transition: 0.3s;
            text-align:center;
        }
        .HomePageForum:hover{
            opacity:1;
        }
        .HomePageForum small{
            position: relative;
            top: 30%;
            left: 0px;
            text-align: center;
            color: black;
            font-weight: bolder;
            font-size: 1.9rem;
            margin-left: auto;
            margin-right: auto;
        }
        .HomePageForumplayer img{
            position: relative;
            top: 15%;
            left: 30px;
            width: 50%;
            height: 50%;
            display: block;
            transition:0.3s;
        }
        .HomePageForumplayer:hover small{
            color:white;
        }
        .HomePageForumplayer small{
            position: relative;
            display: block;
            top: 90px;
            right: 36px;
            height: 0px;
            color:black;
            font-weight:bold;
        }
        
    </style>
</asp:Content>
