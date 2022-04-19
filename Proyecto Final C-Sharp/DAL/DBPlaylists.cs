using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.DAL
{
    public static class DBPlaylists
    {
        //INSERT
        //Inserts a row into Lists
        public static int Insert(SqlConnection connection, string[] values, bool isPrivate)
        {
            if (values.Length != 2) return -1;
            int control = 0;

            //Create the query and the sql command
            string query = @"INSERT INTO Playlists (userEmail, name, private)
                            VALUES (@pUserEmail, @pName, @pPrivate)";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pUserEmail = new SqlParameter("@pUserEmail", System.Data.SqlDbType.NVarChar, 320);
            pUserEmail.Value = values[0];

            SqlParameter pName = new SqlParameter("@pName", System.Data.SqlDbType.NVarChar, 100);
            pName.Value = values[1];

            SqlParameter pPrivate = new SqlParameter("@pPrivate", System.Data.SqlDbType.Bit);
            if (isPrivate) pPrivate.Value = 1;
            else pPrivate.Value = 0;

            //Add sql parameters
            command.Parameters.Add(pUserEmail);
            command.Parameters.Add(pName);
            command.Parameters.Add(pPrivate);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //DELETE
        //Deletes a row from Lists
        //Uses primary key as identifier
        public static int Delete(SqlConnection connection, int primaryKey)
        {
            int control = 0;

            //Create the query and the sql command
            string query = "DELETE FROM Playlists WHERE id = @pId";
            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pId = new SqlParameter("@pId", System.Data.SqlDbType.Int);
            pId.Value = primaryKey;

            //Add sql parameters
            command.Parameters.Add(pId);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //MODIFY
        //Modifies name and private attributes
        //Uses primary key as identifier
        public static int Modify(SqlConnection connection, int primaryKey, string name, bool isPrivate)
        {
            int control = 0;

            //Create the query and the sql command
            string query = @"UPDATE Playlists SET
                            name = @pName, private = @pPrivate
                            WHERE id = @pId";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pName = new SqlParameter("@pName", System.Data.SqlDbType.NVarChar, 100);
            pName.Value = name;

            SqlParameter pPrivate = new SqlParameter("@pPrivate", System.Data.SqlDbType.Bit);
            if (isPrivate) pPrivate.Value = 1;
            else pPrivate.Value = 0;

            SqlParameter pId = new SqlParameter("@pId", System.Data.SqlDbType.Int);
            pId.Value = primaryKey;

            //Add sql parameters
            command.Parameters.Add(pName);
            command.Parameters.Add(pPrivate);
            command.Parameters.Add(pId);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //READ
        //Reads all rows from Lists
        public static SqlDataReader Read(SqlConnection connection)
        {
            string query = "SELECT * FROM Lists";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //READ
        //Selects the rows from Lists of a certain user
        public static SqlDataReader Read(SqlConnection connection, string userEmail)
        {
            string query = "SELECT * FROM Lists WHERE userEmail = @pUserEmail";
            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pUserEmail = new SqlParameter("@pUserEmail", System.Data.SqlDbType.NVarChar, 320);
            pUserEmail.Value = userEmail;

            //Add sql parameters
            command.Parameters.Add(pUserEmail);

            //Execute query
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

    }
}