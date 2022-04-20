using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.DAL;

namespace Proyecto_Final_C_Sharp.Model
{
    public class Playlist
    {
        //Attributes
        private int id;
        private string name, userEmail;
        private bool isPrivate;

        //Constructors
        public Playlist() { }

        public Playlist(int Id, string Name, string UserEmail, bool IsPrivate)
        {
            id = Id;
            name = Name;
            userEmail = UserEmail;
            isPrivate = IsPrivate;
        }
        public Playlist(string Name, string UserEmail)
        {
            id = -1;
            name = Name;
            userEmail= UserEmail;
            isPrivate = true;
        }

        //Get Set
        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string UserEmail { get { return userEmail; } }
        public bool IsPrivate { get { return isPrivate; } set { isPrivate = value; } }

        //DB Access

        //Insert
        //Inserts the playlist into the DB
        //Returns 1 on success
        public int Insert(SqlConnection connection)
        {
            string[] values = { name, userEmail};
            return DBPlaylists.Insert(connection, values, isPrivate);
        }

        //Delete
        //Deletes the playlist from the DB
        //Returns 1 on success
        public int Delete(SqlConnection connection)
        {
            return DBPlaylists.Delete(connection, id);
        }

        //Modify
        //Updates the values of the playlist with the same id
        //Returns 1 on success
        public int Modify(SqlConnection connection)
        {
            return DBPlaylists.Modify(connection, id, name, IsPrivate);
        }

        //Read
        //Returns a list of all playlists from the DB
        public List<Playlist> Read(SqlConnection connection)
        {
            List<Playlist> playlists = new List<Playlist>();
            SqlDataReader reader = DBPlaylists.Read(connection);
            if (reader == null) return null;

            while (reader.Read())
            {
                int nId;
                string nName, nUserEmail;
                bool nIsPrivate;

                nId = (int)reader["id"];
                nName = (string)reader["name"];
                nUserEmail = (string)reader["userEmail"];
                nIsPrivate = (bool)reader["private"];

                Playlist playlist = new Playlist(nId, nName, nUserEmail, nIsPrivate);
                playlists.Add(playlist);
            }

            reader.Close();
            return playlists;
        }

        //---OTHER TABLES---

        //Audios
        //Returns a List of the playlist audios
        public List<Audio> Audios(SqlConnection connection)
        {
            List<Audio> audios = new List<Audio>();
            SqlDataReader reader = DBAudio.Read(connection, id);
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