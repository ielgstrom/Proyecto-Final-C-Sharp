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
        protected void Page_Load(object sender, EventArgs e)
        {
            comprobacionLog();
        }

        public void comprobacionLog(){
            string username = Request["IdUsername"];
            string pass = Request["IdPassword"];

            using (SqlConnection connection = DAL.DBConnection.ConnectLearnifyDB())
            {
                User user = new User();
                user = user.FindUsername(connection, username);

                if (user == null) ; //USER NO EXISTE
                else
                {
                    if (user.Password != pass) ; //CONTRASEÑA MAL
                    else; //TODO OK
                }
                
                //else { lblErrorMessage.Visible = true; }
                
            }
        }
    }
}