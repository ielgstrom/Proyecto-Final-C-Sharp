using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.DAL;

namespace Proyecto_Final_C_Sharp.Model
{
    public class Audio
    {
        //Attributes
        private int id;
        private string name, path, description;

        //Constructors
        public Audio() { }

        public Audio(int Id, string Name, string Path, string Description)
        {
            id = Id;
            name = Name;
            if (name == null) name = "";
            path = Path;
            description = Description;
        }

        public Audio(string Name, string Path)
        {
            id = -1;
            name = Name;
            if (name == null) name = "";
            path = Path;
            description = null;
        }

        //Get Set

        //DB Access

        //Insert
        //Inserts the audio into the DB
        //Returns 1 on success
        public int Insert(SqlConnection connection)
        {
            return DBAudio.Insert(connection, name, path, description);
        }

        //Delete
        //Deletes the audio from the DB
        //Returns 1 on success
        public int Delete(SqlConnection connection)
        {
            return DBAudio.Delete(connection, id);
        }

        //Modify
        //Updates the values of the audio with the same id
        //Returns 1 on success
        public int Modify(SqlConnection connection)
        {
            return DBAudio.Modify(connection, id, name, path, description);
        }

        //Read
        //Returns a list of all playlists from the DB
        public List<Audio> Read(SqlConnection connection)
        {
            List<Audio> audios = new List<Audio>();
            SqlDataReader reader = DBAudio.Read(connection);
            if (reader == null) return null;

            while (reader.Read())
            {
                int nId;
                string nName, nPath, nDescription;

                nId = (int)reader["id"];
                nName = (string)reader["name"];
                if (reader["path"] == DBNull.Value) nPath = null;
                else nPath = (string)reader["path"];
                if (reader["description"] == DBNull.Value) nDescription = null;
                else nDescription = (string)reader["description"];

                Audio audio = new Audio(nId, nName, nPath, nDescription);
                audios.Add(audio);
            }

            reader.Close();

            return audios;
        }

    }
}