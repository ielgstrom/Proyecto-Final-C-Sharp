using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_C_Sharp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btEnviarCorreo_Click(object sender, EventArgs e)
        {
            EnviarMail();
        }

        public void EnviarMail()
        {
            string nombre = Request["nombre"];
            string mail = Request["correo"];
            string desc = Request["txtDesc"];

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(mail, "Prueba", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add("learnify.help@gmail.com"); //Correo destino?
            correo.Subject = nombre; //Asunto
            correo.Body = desc; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("learnify.help@gmail.com", "123contra");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
        }
    }
}