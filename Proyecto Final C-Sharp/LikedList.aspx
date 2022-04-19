<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LikedList.aspx.cs" MasterPageFile="~/NestedMasterPage1.master" Inherits="Proyecto_Final_C_Sharp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
   
    <h1>Titulos que te gustan</h1>
        
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
        <div class="HomePageForumplayer">
        <img src="Imagenes/icons8-play-60.png" />
        <small class="tituloPod">Nombre Podcast</small></div>
     <div class="HomePageForumplayer">
         <img src="Imagenes/icons8-play-60.png" />
         <small class="tituloPod">Nombre Podcast</small>
     </div>
    
    <style>
        .HomePageForumplayer{
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
            margin: 10px;
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
