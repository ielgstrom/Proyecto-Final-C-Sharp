using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_C_Sharp
{
    public partial class Foro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}