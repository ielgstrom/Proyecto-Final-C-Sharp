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

        // enviamos correo al darle al submit
        public void btEnviarCorreo_Click(object sender, EventArgs e)
        {
            EnviarMail();
        }

        // metodo que envia un correo al destinatario de que se ha recibido su peticion
        public void EnviarMail()
        {
            string nombre = name.Text;
            string mail = email.Text;
            string desc = txtDesc.Text;
            
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress(mail, "Learnify Help", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(mail); //Correo destino?
            correo.Subject = "Respuesta petición"; //Asunto
            correo.Body = $@"<h1>Buenos dias, {nombre}</h1>
                            <h2> Muchas gracias por tu interés, </h2>
                            <div>Tu peticion se realizara dentro de poco y te responderemos cuando podamos. Nos has pedido: </div>
                            <p>' {desc} '</p>
                            <p>Cualquier otra consulta que tengas, responde a este correo</p>
                            <p>Atentamente,</p>
                            <p>Equipo de Learnify</p>"; //Mensaje del correo
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

            //Borramos los imputs que habia en la pagina al dar al boton
            name.Text = "";
            email.Text = "";
            txtDesc.Text = "";
        }
    }
}