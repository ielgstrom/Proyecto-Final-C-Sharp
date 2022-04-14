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

            string nombre = Request["inputNombre"];
            string nombreUsuario = Request["inputNombreUsuario"];
            string email = Request["inputEmail"];
            string password = Request["inputContra"];
            string repitePassword = Request["inputRepetirContra"];

            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(nombreUsuario) ||
                String.IsNullOrEmpty(email)|| String.IsNullOrEmpty(password)|| String.IsNullOrEmpty(repitePassword))
            {
                mensajeError.Text = "Rellena todos los campos";
            }
            else
            {
                
            }
        }
    }
}