using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_C_Sharp.Model
{
    public class User
    {
        //Attributes
        private string email, username, password, firstName, lastName;

        //Constructors
        public User(string Email, string Username, string Password, string FirstName, string LastName)
        {
            email = Email;
            username = Username;
            password = Password;
            firstName = FirstName;
            lastName = LastName;
        }

        //Get Set
        public string Email { get { return email; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

    }
}