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
        SqlConnection connection = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            // abrimos conexion con la BBDD
            connection = DAL.DBConnection.ConnectLearnifyDB();
            mensajeError.Text = " ";
        }

        //revisamos los datos del usuario y entramos a la pagina principal
        protected void btSignUp_Click(object sender, System.EventArgs e)
        {
            comprobarDatos();
        }

        private void comprobarDatos()
        {
            // Cogemos los valores de los inputs
            string nombre = Request["inputNombre"];
            string nombreUsuario = Request["inputNombreUsuario"];
            string email = Request["inputEmail"];
            string password = Request["inputContra"];
            string repitePassword = Request["inputRepetirContra"];

            // Revisamos que no hayan campor vacios
            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(nombreUsuario) || String.IsNullOrEmpty(email)|| String.IsNullOrEmpty(password)|| String.IsNullOrEmpty(repitePassword))
                mensajeError.Text = "Rellena todos los campos";
            else
            {
                // Si el nombre existe no se añade
                if(existeNombreUsuario(nombreUsuario))
                    mensajeError.Text = "El nombre de usuario ya existe, escoge otro";
                else
                {
                    // Si la cuenta existe, que inicie sesion
                    if (cuentaExistente(email))
                        mensajeError.Text = "Ya estas registrado, Inicia Sesión";
                    else
                    {
                        // Comprobamos todos los valores de la contraseña
                        if (!comprobarContraseña(password))
                            mensajeError.Text = "La contraseña no contiene los valores pedidos";
                        else
                        {
                            if (password != repitePassword)
                            {
                                mensajeError.Text = "Las contraseñas no coinciden";
                            }
                            else
                            {
                                // Si acepta las condiciones se crea la cuenta
                                if (inputPoliticaPrivacidad.Checked)
                                {
                                    usuario = new User(email, nombreUsuario, Seguridad.Encriptar(password), nombre, null);
                                    usuario.Insert(connection);
                                    Response.Redirect("MainPage.aspx");
                                }
                                else
                                    mensajeError.Text = "Acepta las condiciones y la politica de privacidad";
                            }
                        }
                    }
                }
            }
        }

        #region METODOS
        // Metodo que comprueba que la contraseña contenga numero, mayuscula, minuscula y caracter especial
        public bool comprobarContraseña(string contra)
        {
            var formato = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).*$";

            Regex reg = new Regex(formato);

            return reg.IsMatch(contra);
        }
         
        // Metodo que comprueba si existe el nombre de usuario
        public bool existeNombreUsuario(string nombreUsuario)
        {
            bool validacion = false;
            usuario = new User();

            foreach (User user in usuario.Read(connection))
            {
                if (nombreUsuario == user.Username)
                {
                    validacion = true;
                }
            }

            return validacion;
        }

        // Metodo que comprueba si ya existe la cuenta
        private bool cuentaExistente(string email)
        {
            bool validacion = false;
            usuario = new User();

            foreach (User user in usuario.Read(connection))
            {
                if (email == user.Email)
                {
                    validacion = true;
                }
            }

            return validacion;
        }
        #endregion

    }
}