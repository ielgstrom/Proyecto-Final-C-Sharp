using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.DAL
{
    public static class DBUsers
    {
        //INSERT
        //Inserts a row into Users
        public static int Insert(SqlConnection connection, string[] values)
        {
            if (values.Length != 5) return -1;
            int control = 0;

            //Create the query and the sql command
            string query = @"INSERT INTO Users (email, username, password, firstName, lastName)
                            VALUES (@pEmail, @pUsername, @pPassword, @pFirstName, @pLastName)";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 320);
            pEmail.Value = values[0];

            SqlParameter pUsername = new SqlParameter("@pUsername", System.Data.SqlDbType.NVarChar, 50);
            pUsername.Value = values[1];

            SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.NVarChar, 50);
            pPassword.Value = values[2];

            SqlParameter pFirstName = new SqlParameter("@pFirstName", System.Data.SqlDbType.NVarChar, 50);
            pFirstName.Value = values[3];

            SqlParameter pLastName = new SqlParameter("@pLastName", System.Data.SqlDbType.NVarChar, 50);
            if (values[4] == null) pLastName.Value = DBNull.Value;
            else pLastName.Value = values[4];

            //Add sql parameters
            command.Parameters.Add(pEmail);
            command.Parameters.Add(pUsername);
            command.Parameters.Add(pPassword);
            command.Parameters.Add(pFirstName);
            command.Parameters.Add(pLastName);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //DELETE
        //Deletes a row from users
        //Uses primary key as identifier
        public static int Delete(SqlConnection connection, string PrimaryKey)
        {
            int control = 0;

            //Create the query and the sql command
            string query = "DELETE FROM Users WHERE email = @pEmail";
            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 320);
            pEmail.Value = PrimaryKey;

            //Add sql parameters
            command.Parameters.Add(pEmail);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //MODIFY
        //Modifies all columns from a row in users
        //Uses primary key as identifier
        public static int Modify(SqlConnection connection, string PrimaryKey, string[] values)
        {
            if (values.Length != 4) return -1;
            int control = 0;

            //Create the query and the sql command
            string query = @"UPDATE Users SET
                            username = @pUsername, password = @pPassword, firstName = @pFirstName, lastName = @pLastName
                            WHERE email = @pEmail";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 320);
            pEmail.Value = PrimaryKey;

            SqlParameter pUsername = new SqlParameter("@pUsername", System.Data.SqlDbType.NVarChar, 50);
            pUsername.Value = values[0];

            SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.NVarChar, 50);
            pPassword.Value = values[1];

            SqlParameter pFirstName = new SqlParameter("@pFirstName", System.Data.SqlDbType.NVarChar, 50);
            pFirstName.Value = values[2];

            SqlParameter pLastName = new SqlParameter("@pLastName", System.Data.SqlDbType.NVarChar, 50);
            if (values[3] == null) pLastName.Value = DBNull.Value;
            else pLastName.Value = values[3];

            //Add sql parameters
            command.Parameters.Add(pEmail);
            command.Parameters.Add(pUsername);
            command.Parameters.Add(pPassword);
            command.Parameters.Add(pFirstName);
            command.Parameters.Add(pLastName);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //READ
        //Reads all rows from users
        public static SqlDataReader Read(SqlConnection connection)
        {
            string query = "RETURN * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //READ
        //Reads top *length* rows from users
        public static SqlDataReader Read(SqlConnection connection, int length)
        {
            //Create the query and the sql command
            string query = "RETURN TOP @pLength FROM Users";
            SqlCommand command = new SqlCommand(query, connection);

            //Create and add parameter
            SqlParameter pUsername = new SqlParameter("@pLength", System.Data.SqlDbType.Int);
            pUsername.Value = length;
            command.Parameters.Add(pUsername);

            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //FIND
        //Returns the user with the specified PK
        public static SqlDataReader Find(SqlConnection connection, string PrimaryKey)
        {
            //Create the query and the sql command
            string query = "RETURN * FROM Users WHERE email = @pEmail";
            SqlCommand command = new SqlCommand(query, connection);

            //Create and add parameter
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 320);
            pEmail.Value = PrimaryKey;
            command.Parameters.Add(pEmail);

            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }


    }
}