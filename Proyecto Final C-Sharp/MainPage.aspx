<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" MasterPageFile="~/NestedMasterPage1.master" Inherits="Proyecto_Final_C_Sharp.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <script type="text/javascript" src="Scripts/pruebaPlayer.js"></script>

    <asp:Label ID="welcomeLabel" runat="server"  Text="Bienvenido," Font-Size="23"></asp:Label>
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
    <div class="containerPlayer">
      <div class="child">
        <div id="main-area">
          <form action="javascript:void(0);">
          <asp:Panel runat="server" ID="podcastsVideos"></asp:Panel>
           <%-- <div class="bar">
              <input id="input-field" type="url"
                  value="https://www.youtube.com/watch?v=48Ltw4R6yIA"/>
              <img id="pruebaImg" runat="server" src="https://i.ytimg.com/vi/48Ltw4R6yIA/hqdefault.jpg" height="170" width="250"/>
              <button class="btnPlay" id="play" title="play video url"><i class="fa fa-solid fa-play"></i></button>
            </div>--%>

          </form>
        </div>
       </div>
      </div>
    </div>

    <div id="overlay">
      <div id="overlay-content">
        <div>
          <button class="overlay-buttons transparent-button material-icons-round" title="close" > close </button>
          <button class="overlay-buttons transparent-button material-icons-round" title="maximize" > check_box_outline_blank </button>
        </div>

        <progress id="loader" title="loading video..."></progress>
        <iframe id="videoPlayer" loading="eager" allowfullscreen="true">
          <p>Your browser does not support iframes.</p>
        </iframe>

      </div>

          <div id="options-div"> 
            <button id="options-button" class="transparent-button material-icons-round">settings</button>
            <div id="options-dropdown">
              <div id="reload" class="options">reload video</div>
              <div id="private-mode" class="options" data-enabled="false" title="private mode is currently disabled(click to enable)">private mode</div>
              <div id="open-video" class="options">open video on youtube</div>
            </div>
          </div>

    </div>
    <div id="expand-box" class="hidden">
      <img src="#" id="thumbnail" title="click to reopen minimized video">
      <div id="expand-hint-text">minimized video</div>
    </div>
    <div id="shortcuts-modal" class="modal">
      <!-- Modal content -->
      <div class="modal-content">
        <span
          id="close"
          class="overlay-buttons transparent-button material-icons-round"
          >close</span
        >
        <h3>Keyboard Shortcuts</h3>
        <p>Press <kbd>?</kbd> to toggle this modal.</p>
        <hr />
        <div>
          <p>Full screen <kbd>f</kbd></p>
          <p>Reload video <kbd>r</kbd></p>
          <p>Minimize video overlay <kbd>m</kbd> or <kbd>_</kbd></p>
          <p>Open video overlay <kbd>o</kbd> or <kbd>+</kbd></p>
          <p>Close video overlay <kbd>Esc</kbd> or <kbd>x</kbd></p>
        </div>
      </div>
    </div>
 
</asp:Content>
