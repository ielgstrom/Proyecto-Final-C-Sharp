using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.DAL;

namespace Proyecto_Final_C_Sharp.Model
{
    public class User
    {
        //Attributes
        private string email, username, password, firstName, lastName;

        //Constructors
        public User() { }
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

        //DB Acess

        //Insert
        //Inserts the user into the DB
        //Returns 1 on success
        public int Insert(SqlConnection connection)
        {
            string[] values = { email, username, password, firstName, lastName };
            return DBUsers.Insert(connection, values);
        }

        //Delete
        //Deletes the user from the DB
        //Returns 1 on success
        public int Delete(SqlConnection connection)
        {
            return DBUsers.Delete(connection, email);
        }

        //Modify
        //Updates the values of the user with the same email
        //Returns 1 on success
        public int Modify(SqlConnection connection)
        {
            string[] values = { username, password, firstName, lastName };
            return DBUsers.Modify(connection, email, values);
        }

        //Read
        //Returns a list of users from the DB
        public List<User> Read(SqlConnection connection)
        {
            List<User> users = new List<User>();
            SqlDataReader reader = DBUsers.Read(connection);
            if (reader == null) return null;

            while (reader.Read())
            {
                string nEmail, nUsername, nPassword, nFirstName, nLastName;
                nEmail = (string)reader["email"];
                nUsername = (string)reader["username"];
                nPassword = (string)reader["password"];
                nFirstName = (string)reader["firstName"];
                if (reader["lastName"] == DBNull.Value) nLastName = null;
                else nLastName = (string)reader["lastName"];
                User user = new User(nEmail, nUsername, nPassword, nFirstName, nLastName);
                users.Add(user);
            }

            reader.Close();

            return users;
        }

        //Find
        //Returns the user with the specified email
        //Returns null if not found
        public User Find(SqlConnection connection, string primaryKey)
        {
            User user = null;

            SqlDataReader reader = DBUsers.Find(connection, primaryKey);
            if (reader.Read())
            {
                string nEmail, nUsername, nPassword, nFirstName, nLastName;
                nEmail = (string)reader["email"];
                nUsername = (string)reader["username"];
                nPassword = (string)reader["password"];
                nFirstName = (string)reader["firstName"];
                if (reader["lastName"] == DBNull.Value) nLastName = null;
                else nLastName = (string)reader["lastName"];
                user = new User(nEmail, nUsername, nPassword, nFirstName, nLastName);
            }
            reader.Close();

            return user;
        }

        //---OTHER TABLES---

        //Messages
        //Returns all messages written by the user
        public List<Message> Messages(SqlConnection connection)
        {
            List<Message> messages = new List<Message>();
            SqlDataReader reader = DBMessages.Read(connection, email);
            if (reader == null) return null;
            while (reader.Read())
            {
                int nId;
                string nUserEmail, nMessageText, nTopic;
                DateTime nCreationDate;
                int? nRespondsToId;

                nId = (int)reader["id"];
                nUserEmail = (string)reader["userEmail"];
                nCreationDate = (DateTime)reader["creationDate"];
                nMessageText = (string)reader["messageText"];
                if (reader["respondsToId"] == DBNull.Value) nRespondsToId = null;
                else nRespondsToId = (int?)reader["respondsToId"];
                if (reader["topic"] == DBNull.Value) nTopic = null;
                else nTopic = (string)reader["topic"];

                //messages.Add(new Message(nId, nUserEmail, nCreationDate, nMessageText, nRespondsToId));
            }

            reader.Close();
            return messages;
        }

        //Playlists
        //Returns every playlist owned by the user
        public List<Playlist> Playlists(SqlConnection connection)
        {
            List<Playlist> playlists = new List<Playlist>();
            SqlDataReader reader = DBPlaylists.Read(connection, email);
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

    }
}