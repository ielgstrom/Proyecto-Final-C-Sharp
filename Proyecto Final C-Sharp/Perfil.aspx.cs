using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.Model;
using System.Text.RegularExpressions;

namespace Proyecto_Final_C_Sharp
{
    public partial class Perfil : System.Web.UI.Page
    {
        private User user;
        private SqlConnection connection;
        private string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Request connection an user
            //Requires info from both DB and cookie
            connection = DAL.DBConnection.ConnectLearnifyDB();
            user = new User();

            if (Request.Cookies["myusrname"] == null)
            {
                //REDIR
                Response.Redirect("PantallaInicial.aspx");
            }
            username = Request.Cookies["myusrname"].Value;
            user = user.FindUsername(connection, username);

            //Test Line (to test without cookie)
            //user = user.FindUsername(connection, "modificar");

            if (user == null)
            {
                //User not in DB
                Response.Redirect("PantallaInicial.aspx");
            }
            if (!IsPostBack)TextBoxName.Text = user.FirstName;
            LabelError.Text = "";
            LabelError2.Text = "";

        }

        protected void CloseSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaInicial.aspx");
        }

        protected void SaveChanges_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (TextBoxOldPassw.Text != Seguridad.DesEncriptar(user.Password))
            {
                //Wrong password
                LabelError.Text = "Contraseña incorrecta";
                ok = false;
            }
            else if(!comprobarContraseña(TextBoxNewPassw1.Text))
            {
                //New password wrong format
                LabelError.Text = "La nueva contraseña no contiene los valores pedidos";
                ok = false;
            }
            else if (TextBoxNewPassw1.Text != TextBoxNewPassw2.Text)
            {
                //Passwords not matching
                LabelError.Text = "Debes escribir la nueva contraseña dos veces";
                ok = false;
            }
            if (TextBoxName.Text.Length > 49)
            {
                //Name is too long
                LabelError2.Text += "El nombre es demasiado largo\n";
                ok = false;
            }
            if (ok)
            {
                user.FirstName = TextBoxName.Text;
                user.Password = Seguridad.Encriptar(TextBoxNewPassw1.Text);
                user.Modify(connection);
                Response.Redirect(Request.RawUrl);
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