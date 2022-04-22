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
        public Audio audio = new Audio();
        public List<Audio> listaAudios = null;
        Message mensajes = new Message();
        List<String> listaTopics = null;
        SqlConnection connection = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["myusrname"] == null)
            {
                welcomeLabel.Text = " ";
            }
            else
            {
                welcomeLabel.Text = welcomeLabel.Text + " " + this.Request.Cookies["myusrname"].Value;
            }

            connection = DAL.DBConnection.ConnectLearnifyDB();
            listaAudios = audio.Read(connection);
            listaTopics = mensajes.Topics(connection);

            //Aqui inicializamos los foros recomendados, y de momento recomendamos solo 6, para no incluirlos todos
            for(int y=0; y<6; y++)
            {
                MainForosPanel.Controls.Add(new Literal() { Text = $@"<div class='HomePageForum'>
                                                <a class='enlaceMainForo' href='Foro.aspx?topic={listaTopics[y]}'>
                                                    <small>
                                                        {listaTopics[y]}
                                                    </small>
                                                </a>
                                            </div>" });
            }


            for (int i = 0; i < listaAudios.Count; i++)
            {
                String url = listaAudios[i].Path;
                int tam_var = url.Length;
                String idURL = url.Substring((tam_var - 11), 11);

                podcastsVideos.Controls.Add(new Literal() { Text = $@"<div class='bar'>
                    <input class='inputField' id='input-field{i}' type='url'
                    value='{url}'/>
                    <img id='pruebaImg' runat='server' src='https://i.ytimg.com/vi/{idURL}/hqdefault.jpg' height='170' width='250'/>
                    <button class='btnPlay' id='play{i}' title='play video url' value='input-field{i}'><i class='fa fa-solid fa-play'></i></button>
                    <label>{url}</label>
                    </div>" });
            }
        }
    }
}