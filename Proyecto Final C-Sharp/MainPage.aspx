<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" MasterPageFile="~/NestedMasterPage1.master" Inherits="Proyecto_Final_C_Sharp.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">

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
    <script type="text/javascript" src="Scripts/pruebaPlayer.js"></script>
    <style>
        :root {
  font-family: "Roboto Mono", monospace;
  margin: 0;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  line-height: 1.6rem;
  border-radius: 0.2rem;
}

h1 {
  color: black;
  text-align: center;
  margin: 1.2rem 0 10.5rem 0;
  line-height: 2rem;
}

kbd {
  padding: 0.1em 0.6em;
  border: 1px solid #ccc;
  font-size: 11px;
  font-family: Arial, Helvetica, sans-serif;
  background-color: #f7f7f7;
  color: #333;
  -moz-box-shadow: 0 1px 0 rgba(0, 0, 0, 0.2), 0 0 0 2px #fff inset;
  -webkit-box-shadow: 0 1px 0 rgba(0, 0, 0, 0.2), 0 0 0 2px #fff inset;
  box-shadow: 0 1px 0 rgba(0, 0, 0, 0.2), 0 0 0 2px #fff inset;
  border-radius: 3px;
  display: inline-block;
  margin: 0.1em;
  text-shadow: 0 1px 0 #fff;
  line-height: 1.4;
  white-space: nowrap;
}

#input-field {
  width: 100%;
  border: none;
  font: inherit;
  padding: 0.4rem 2rem;
  margin-right: 0.4rem;
  border-color: black;
  border-radius: 0.2rem;
}

button:disabled:not(#expand:disabled) {
  opacity: 0.5;
  cursor: not-allowed;
}

legend,
#notification {
  text-align: center;
}

#input-field.wrong {
  background: rgba(198, 38, 46, 0.3);
}

.wrong {
  color: #c6262e;
}

.correct {
  color: #68b723;
}

.normal {
  color: black;
}

.center {
  display: flex;
  justify-content: center;
  align-items: center;
}

.hidden,
#expand:disabled {
  display: none;
}

/* TODO: find way to change progress bar color */
#loader {
  margin: 0.25em;
  z-index: 9999;
  width: 10rem;
  height: 0.5rem;
}

#main-area {
  margin-top: 1rem;
  padding: 1.4rem 1rem;
  border-radius: 0.4rem;
  background: #eaeaea;
}

.fade {
  animation: fade 2s ease-in infinite;
}

#loader-fade-text {
  animation: fade 2s ease-in infinite, rgb 5s linear infinite;
}

@keyframes fade {
  0% {
    opacity: 0;
  }

  25% {
    opacity: 0.5;
  }

  50% {
    opacity: 1;
  }

  75% {
    opacity: 0.5;
  }

  100% {
    opacity: 0;
  }
}

@keyframes rgb {
  0% {
    color: #f44336;
  }

  25% {
    color: #ffc107;
  }

  50% {
    color: #4caf50;
  }

  75% {
    color: #3f51b5;
  }

  100% {
    color: #f44336;
  }
}

@keyframes rgb-bg {
  0% {
    background-color: #f44336;
  }

  25% {
    background-color: #ffc107;
  }

  50% {
    background-color: #4caf50;
  }

  75% {
    background-color: #3f51b5;
  }

  100% {
    background-color: #f44336;
  }
}

@keyframes rgb-border {
  0% {
    border-color: #f44336;
  }

  25% {
    border-color: #ffc107;
  }

  50% {
    border-color: #4caf50;
  }

  75% {
    border-color: #3f51b5;
  }

  100% {
    border-color: #f44336;
  }
}

.bar {
  display: flex;
  justify-content: space-between;
}

fieldset {
  border-style: solid;
  border-radius: 0.2rem;
}

button {
  border: none;
  font: inherit;
  padding: 0.4rem 1rem;
  border-radius: 0.2rem;
  font-size: 1.2rem;
  cursor: pointer;
  background: #d4d4d4;
  color: black;
}

.valid {
  border-width: 2px;
  border-style: solid;
  animation: rgb-border 5s linear infinite;
}

.overlay-buttons {
  color: white;
  transition-duration: 0.5s;
  padding: 0.25em;
  float: right;
}

.overlay-buttons:hover,
#close:hover {
  color: black !important;
  /* border-radius: 25%; */
}

#videoPlayer {
  width: 65vw;
  height: calc((9/16) * 65vw);
  border-style: hidden;
  border-radius: 0.2em;
}

#overlay {
  position: fixed;
  display: none;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background-color: rgba(0, 0, 0, 0.5);
  z-index: auto;
  cursor: default;
}

#overlay-content {
  position: absolute;
  top: 50%;
  left: 50%;
  font-size: 50px;
  color: white;
  transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
}

.container {
  position: relative;
  display: flex;
  justify-content: center;
  margin: auto;
}

.child {
  /* Center vertically */
  position: absolute;
  top: 50%;
}

#expand-box {
  background-color: #d4d4d4;
  border: 1px solid #1a1a1a;
  border-radius: 0.2rem;
  margin: 1rem;
  position: absolute;
  bottom: 0;
  right: 0;
  cursor: pointer;
}

#expand-hint-text {
  color: black;
  background-color: inherit;
  font-size: 1.2rem;
  text-align: center;
  padding: 0.4rem 1rem;
}

img {
  background-color: #d4d4d4;
}

/* The Modal (background) */
.modal {
  /* Hidden by default */
  display: none;
  /* Stay in place */
  position: fixed;
  /* Sit on top */
  z-index: 1;
  left: 0;
  top: 0;
  /* Full width */
  width: 100%;
  /* Full height */
  height: 100%;
  /* Enable scroll if needed */
  overflow: auto;
  /* Fallback color */
  background-color: rgb(0, 0, 0);
  /* Black w/ opacity */
  background-color: rgba(0, 0, 0, 0.4);
}

/* Modal Content/Box */
.modal-content {
  background-color: #fefefe;
  /* 15% from the top and centered */
  margin: 15% auto;
  padding: 10px;
  border: 1px solid #888;
  border-radius: 0.2em;
  /* Could be more or less, depending on screen size */
  width: 55%;
}

#close {
  color: grey;
}

.no-select,
.overlay-buttons {
  user-select: none;
  /* iOS Safari */
  -webkit-touch-callout: none;
  /* Safari */
  -webkit-user-select: none;
  /* Konqueror HTML */
  -khtml-user-select: none;
  /* Old versions of Firefox */
  -moz-user-select: none;
  /* Internet Explorer/Edge */
  -ms-user-select: none;
}

.transparent-button {
  background-color: transparent;
  background-repeat: no-repeat;
  border: none;
  cursor: pointer;
  overflow: hidden;
  outline: none;
}

#options-div {
  margin: 1rem;
  position: fixed;
  bottom: 0;
  right: 0;
}

#options-button {
  color: white;
  transition-duration: 1s;
  border: 3px solid #a56de2;
  border-radius: 0.4rem;
  padding: 0.5rem;
  float: right;
}

#options-dropdown {
  border-radius: 0.2rem;
  display: none;
  position: absolute;
  right: 0;
  background-color: rgb(249, 249, 249);
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0, 0, 0, 0.2);
  z-index: 1;
  bottom: 100%;
}

.options {
  cursor: pointer;
  border-radius: 0.2rem;
}

#options-dropdown .options {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

#options-dropdown .options:hover {
  border: 3px solid #a56de2;
}

#options-div:hover #options-dropdown {
  display: block;
}

#options-div:hover #options-button {
  color: black;
}

#private-mode {
  transition: background-color 1s ease;
}

    </style>

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
    <!--
    <figure>
        <figcaption>Listen to the T-Rex:</figcaption>
        <audio
            controls
            src="https://www.youtube.com/watch?v=fWOlTvmBiQA&list=PLcaI8vM1NK3teGT4oVi9JzyX8WLdkgbz_&index=4">
                Your browser does not support the
                <code>audio</code> element.
        </audio>
    </figure>
    -->

    <div class="container">
      <div class="child">
        <div id="notification"></div>
        <div id="main-area">
          <form action="javascript:void(0);">
            <div class="bar HomePageForumplayer">
              <input
                id="input-field"
                type="url"
                autofocus
                required
                placeholder="enter youtube video url"
                title="enter a youtube video url"
                size="22"
                minlength="20"
                maxlength="80"
              />
              <button
                id="play"
                title="play video url"
              >
                play
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>

    <div id="overlay">
      <div id="overlay-content">
        <div>
          <button
            class="overlay-buttons transparent-button material-icons-round"
            title="close"
          >
            close
          </button>
          <button
            class="overlay-buttons transparent-button material-icons-round"
            title="maximize"
          >
            check_box_outline_blank
          </button>
          <button
            class="overlay-buttons transparent-button material-icons-round"
            title="minimize"
          >
            minimize
          </button>
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
              <!-- <div>Link 3</a> -->
            </div>
          </div>

    </div>
    <div id="expand-box" class="hidden">
      <img id="thumbnail" title="click to reopen minimized video">
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
