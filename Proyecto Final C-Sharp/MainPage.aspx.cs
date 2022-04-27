using Proyecto_Final_C_Sharp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_C_Sharp
{
    public partial class MainPage : System.Web.UI.Page
    {
        // variables
        public Audio audio = new Audio();
        public List<Audio> listaAudios = null;
        Message mensajes = new Message();
        List<String> listaTopics = null;
        SqlConnection connection = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            // comprobamos que el usuario este logueado a traves de las cookies
            if (Request.Cookies["myusrname"] == null)
                welcomeLabel.Text = " ";
            else
                welcomeLabel.Text = welcomeLabel.Text + " " + this.Request.Cookies["myusrname"].Value;

            // inicializamos variables
            connection = DAL.DBConnection.ConnectLearnifyDB();
            listaAudios = audio.Read(connection);
            listaTopics = mensajes.Topics(connection);

            //Aqui inicializamos los foros recomendados, y de momento recomendamos solo 6, para no incluirlos todos
            for(int y=0; y<6; y++)
            {
                mainForosPanel.Controls.Add(new Literal() { Text = $@"<div class='HomePageForum'>
                                                <a class='enlaceMainForo' href='Foro.aspx?topic={listaTopics[y]}'>
                                                    <small style='color:white'>
                                                        {listaTopics[y]}
                                                    </small>
                                                </a>
                                            </div>" });
            }

            //Aqui inicializamos los podcasts recomendados, y de momento recomendamos solo 6, para no incluirlos todos
            for (int i = 0; i < 8; i++)
            {
                String url = listaAudios[i].Path;
                int tam_var = url.Length;
                String idURL = url.Substring((tam_var - 11), 11);

                podcastsVideos.Controls.Add(new Literal() { Text = $@"<div class='bar'>
                    <img id='pruebaImg' runat='server' src='https://i.ytimg.com/vi/{idURL}/hqdefault.jpg' height='170' width='250'/>
                    <input type='button' class='btnPlay' id='play{i}' runat='server' value='{url}' style='opacity: 0'></input>
                    </div>" });
            }

        }
    }
}