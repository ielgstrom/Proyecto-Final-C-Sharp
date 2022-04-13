using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Final_C_Sharp.DAL;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.Model
{
    public class Model
    {
        private List<User> users;

        //Constructor
        public Model()
        {
            users = new List<User>();
        }

        //Get Set
        public List<User> Users { get { return users; } }

        //DB methods

        //Add a user
        //Returns 1 when a user is correct and added to the DB
        //else returns -1
        public int AddUser(SqlConnection connection, User user)
        {
            string[] values = new string[5];
            values[0] = user.Email;
            values[1] = user.Username;
            values[2] = user.Password;
            values[3] = user.FirstName;
            values[4] = user.LastName;

            return DBUsers.Insert(connection, values);
        }

    }
}