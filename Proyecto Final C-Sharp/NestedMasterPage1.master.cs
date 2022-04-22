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
    public partial class NestedMasterPage1 : System.Web.UI.MasterPage
    {
        Message mensajes = new Message();
        List<String> listaTopics = null;
        SqlConnection connection = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = DAL.DBConnection.ConnectLearnifyDB();


            if (Request.Cookies["myusername"] == null){
                //REDIR
                Response.Redirect("PantallaInicial.aspx");
            }

            string cookieUser = this.Request.Cookies["myusername"].Value;

            User user = new User();
            user = user.FindUsername(connection, cookieUser);

            if(user == null)
            {
                Response.Redirect("PantallaInicial.aspx");
            }
            else
            {
                listaTopics = mensajes.Topics(connection);
                for (int i = 0; i < listaTopics.Count; i++)
                {
                    listForos.Controls.Add(new Literal() { Text = $"<a class='forosLinks' href='Foro.aspx?topic={listaTopics[i]}'>{listaTopics[i]}</a>" });
                }
            }
        }
    }
}