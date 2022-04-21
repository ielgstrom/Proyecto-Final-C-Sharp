﻿using Proyecto_Final_C_Sharp.Model;
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
            if (Request.Cookies["myusrname"] != null)
            {
                Username = Request.Cookies["myusrname"].Value;
            }
            for (int i =0; i < listaMensajes.Count; i++)
            {
                if (Request.QueryString["topic"] == listaMensajes[i].Topic)
                {
                if (Username == usuario.Find(connection, listaMensajes[i].UserEmail).Username)
                    {
                        contenedorMensajesTest.Controls.Add(new Literal() { Text = $@"<div class='mensajeIndividual mensajeIndividualUser'>
                <small class='nameForumPerson '>Tu</small> - <small class='dateForumPost'>{listaMensajes[i].CreationDate}</small>
                <div class='messageContent'>
                    {listaMensajes[i].MessageText}
                </div>
                </div>" });
                    }

                    else
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
            Label1.Text = $"Foro: {Request.QueryString["topic"]}";
            SetFocus(InputForo);
        }

        protected void ButtonJoin_Click(object sender, EventArgs e)
        {
            if (ButtonJoin.Text == "Unirse")
            {
                ButtonJoin.Text = "Salir";
                InputForo.Enabled = true;
            }
            else if (ButtonJoin.Text == "Salir")
            {
                ButtonJoin.Text = "Unirse";
                InputForo.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Message nuevoMensaje = new Message("prueba@psd.com", InputForo.Text, Request.QueryString["topic"]);
            nuevoMensaje.Insert(connection);
            Response.Redirect(Request.RawUrl);
        }
    }
}