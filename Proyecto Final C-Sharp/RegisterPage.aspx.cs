using Proyecto_Final_C_Sharp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Proyecto_Final_C_Sharp
{
    public partial class Registro : System.Web.UI.Page
    {
        public User usuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            mensajeError.Text = " ";
        }

        protected void btSignUp_Click(object sender, System.EventArgs e)
        {
            comprobarDatos();
        }

        private void comprobarDatos()
        {
            SqlConnection connection = DAL.DBConnection.ConnectLearnifyDB();
            bool validacion = false;

            string nombre = Request["inputNombre"];
            string nombreUsuario = Request["inputNombreUsuario"];
            string email = Request["inputEmail"];
            string password = Request["inputContra"];
            string repitePassword = Request["inputRepetirContra"];

            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(nombreUsuario) ||
                String.IsNullOrEmpty(email)|| String.IsNullOrEmpty(password)|| String.IsNullOrEmpty(repitePassword))
            {
                mensajeError.Text = "Rellena todos los campos";
            }
            else
            {
                usuario = new User();

                foreach(User user in usuario.Read(connection))
                {
                    if (nombreUsuario == user.Username)
                    {
                        validacion = true;
                    }
                }

                if(validacion)
                {
                    mensajeError.Text = "El nombre de usuario ya existe";
                }
                else
                {
                    if (!comprobarContraseña(password))
                        mensajeError.Text = "La contraseña no contiene los valores pedidos";
                    else
                    {
                        if (password == repitePassword)
                        {
                            usuario = new User(email, nombreUsuario, password, nombre, null);
                            usuario.Insert(connection);
                        }
                        else
                            mensajeError.Text = "Las contraseñas no coinciden";
                    }
                }
            }
        }

        public bool comprobarContraseña(string contra)
        {
            var formato = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).*$";

            Regex reg = new Regex(formato);

            return reg.IsMatch(contra);
        }
    }
}