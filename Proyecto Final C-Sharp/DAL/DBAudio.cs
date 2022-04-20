using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.DAL
{
    public static class DBAudio
    {
        //INSERT
        //Inserts a row into Audio
        public static int Insert(SqlConnection connection, string name, string path, string description)
        {
            int control = 0;
            string query = @"INSERT INTO Audio (name, path, description)
                            VALUES (@pName, @pPath, @pDescription)";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pName = new SqlParameter("@pName", System.Data.SqlDbType.NVarChar, 50);
            pName.Value = name;

            SqlParameter pPath = new SqlParameter("@pPath", System.Data.SqlDbType.Text);
            if (path == null) pPath.Value = DBNull.Value;
            else pPath.Value = path;

            SqlParameter pDescription = new SqlParameter("@pDescription", System.Data.SqlDbType.NVarChar, 250);
            if (description == null) pDescription.Value = DBNull.Value;
            else pDescription.Value = description;

            //Add sql parameters
            command.Parameters.Add(pName);
            command.Parameters.Add(pPath);
            command.Parameters.Add(pDescription);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //DELETE
        //Deletes a row from Audio
        //Uses primary key as identifier
        public static int Delete(SqlConnection connection, int primaryKey)
        {
            int control = 0;

            //Create the query and the sql command
            string query = "DELETE FROM Audio WHERE id = @pId";
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
        public static int Modify(SqlConnection connection, int primaryKey, string name, string path, string description)
        {
            int control = 0;
            string query = @"UPDATE Audio SET
                            name = @pName, path = @pPath, description = @pDescription
                            WHERE id = @pId";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pId = new SqlParameter("@pId", System.Data.SqlDbType.Int);
            pId.Value = primaryKey;

            SqlParameter pName = new SqlParameter("@pName", System.Data.SqlDbType.NVarChar, 50);
            pName.Value = name;

            SqlParameter pPath = new SqlParameter("@pPath", System.Data.SqlDbType.Text);
            if (path == null) pPath.Value = DBNull.Value;
            else pPath.Value = path;

            SqlParameter pDescription = new SqlParameter("@pDescription", System.Data.SqlDbType.NVarChar, 250);
            if (description == null) pDescription.Value = DBNull.Value;
            else pDescription.Value = description;

            //Add sql parameters
            command.Parameters.Add(pId);
            command.Parameters.Add(pName);
            command.Parameters.Add(pPath);
            command.Parameters.Add(pDescription);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //READ
        //Reads all rows from Audio
        public static SqlDataReader Read(SqlConnection connection)
        {
            string query = "SELECT * FROM Audio";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //READ
        //Reads every Audio from a certain Playlist
        public static SqlDataReader Read(SqlConnection connection, int idPlaylist)
        {
            string query = @"SELECT * FROM Audio AS a
                            INNER JOIN PlaylistAudio AS pa ON a.id = pa.idAudio
                            INNER JOIN Playlists AS p ON pa.idPlaylist = p.id
                            WHERE p.id = @pId";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pId = new SqlParameter("@pId", System.Data.SqlDbType.Int);
            pId.Value = idPlaylist;

            //Add sql parameters
            command.Parameters.Add(pId);

            //Execute query
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}