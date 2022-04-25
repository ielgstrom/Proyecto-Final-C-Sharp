using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.Model;

namespace Proyecto_Final_C_Sharp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        bool esCorrecto = false;
        protected void Page_Load(object sender, EventArgs e)
        { 
        }

        public void comprobacionLog(){
            string username = Request["IdUsername"];
            string pass = Request["inputContra"];

            using (SqlConnection connection = DAL.DBConnection.ConnectLearnifyDB())
            {
                User user = new User();
                user = user.FindUsername(connection, username);

                if (user == null)
                {
                    mensajeError.Text = "El nombre de usuario no existe, escoge otro";
                    //USER NO EXISTE
                }
                else
                {
                    if (user.Password != Seguridad.Encriptar(pass))
                    {
                        mensajeError.Text = "La contraseña es incorrecta";
                    }//CONTRASEÑA MAL
                    else
                    {
                        HttpCookie myusrname = new HttpCookie("myusrname", username);

                        Response.Cookies.Add(myusrname);
                        Response.Redirect("MainPage.aspx");
                    }//TODO OK
                }
            }
        }

        protected void btIniciarSesion_Click(object sender, EventArgs e)
        {
            comprobacionLog();
        }
    }
}