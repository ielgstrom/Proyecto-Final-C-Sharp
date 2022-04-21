using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Proyecto_Final_C_Sharp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void comprobacionLog(){
            string username = Request["IdUsername"];
            string pass = Request["pass"];

            using (SqlConnection connection = DAL.DBConnection.ConnectLearnifyDB())
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, connection);
                sqlCmd.Parameters.AddWithValue("@username", IdUsername);
                sqlCmd.Parameters.AddWithValue("@password", pass);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (count == 1)
                {
                    Session["username"] = username;
                    Response.Redirect("MainPage.aspx");
                }
                //else { lblErrorMessage.Visible = true; }
                
            }
        }
    }
}