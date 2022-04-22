using Proyecto_Final_C_Sharp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Proyecto_Final_C_Sharp
{
    public partial class Foro : System.Web.UI.Page
    {
        Message mensajes = new Message();
        List<Message> listaMensajes = null;
        SqlConnection connection = null;
        User usuario = new User();
        string Username = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = DAL.DBConnection.ConnectLearnifyDB();
            listaMensajes = mensajes.Read(connection);
            if (Request.Cookies["myusrname"] != null) //Me guardo a cookie si existe
            {
                Username = Request.Cookies["myusrname"].Value;
            }
            else
            {
                InputForo.Enabled = false; //Medida de preaución: no poder escribir si no hay usuario en las cookies
                Button1.Enabled = false; //También el botón
            }
            for (int i =0; i < listaMensajes.Count; i++) //Hago un loop por todos los mensajes
            {
                if (Request.QueryString["topic"] == listaMensajes[i].Topic) //Filtra por query el topic del foro
                {
                    if (Username == usuario.Find(connection, listaMensajes[i].UserEmail).Username) //Si el usuario del mensaje es el de las cookies, escribe el texto de una forma
                    {
                        contenedorMensajesTest.Controls.Add(new Literal() { Text = $@"<div class='mensajeIndividual mensajeIndividualUser'>
                        <small class='nameForumPerson '>Tu</small> - <small class='dateForumPost'>{listaMensajes[i].CreationDate}</small>
                        div class='messageContent'>
                        {listaMensajes[i].MessageText}
                        </div>
                        </div>" });
                    }
                    else //Sino, como un mensaje generico
                    {
                        contenedorMensajesTest.Controls.Add(new Literal() { Text=$@"<div class='mensajeIndividual mensajeIndividualOther'>
                        <small class='nameForumPerson'>{usuario.Find(connection,listaMensajes[i].UserEmail).Username}</small> - <small class='dateForumPost'>{listaMensajes[i].CreationDate}</small>
                        <div class='messageContent'>
                            {listaMensajes[i].MessageText}
                        </div>
                        </div>" });
                    }
                }
            }
            Label1.Text = $"Foro: {Request.QueryString["topic"]}"; //Cambiar el titulo del foro
            SetFocus(InputForo); //Al hacer refresh que haga autofocus al input
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User usuario2 = new User();
            connection = DAL.DBConnection.ConnectLearnifyDB();
            Message nuevoMensaje = new Message(usuario2.FindUsername(connection, Request.Cookies["myusrname"].Value).Email, InputForo.Text, Request.QueryString["topic"]);
            nuevoMensaje.Insert(connection);
            Response.Redirect(Request.RawUrl);
        }
    }
}