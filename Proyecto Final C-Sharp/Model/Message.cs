using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proyecto_Final_C_Sharp.DAL;

namespace Proyecto_Final_C_Sharp.Model
{
    public class Message
    {
        //Attributes
        private int id;
        private string userEmail, messageText;
        private DateTime creationDate;
        private int? respondsToId;
        private string topic;

        //Constructors
        public Message () { }

        public Message(int Id, string UserEmail, DateTime CreationDate, string MessageText, int? RespondsToId, string Topic)
        {
            id = Id;
            userEmail = UserEmail;
            creationDate = CreationDate;
            messageText = MessageText;
            respondsToId = RespondsToId;
            topic = Topic;
        }

        public Message(string UserEmail, string MessageText, string Topic)
        {
            id = -1;
            userEmail= UserEmail;
            creationDate = DateTime.Now;
            messageText = MessageText;
            respondsToId = null;
            topic = Topic;
        }

        //Get Set
        public int Id { get { return id; } }
        public string UserEmail { get { return userEmail; } }
        public DateTime CreationDate { get { return creationDate; } }
        public string MessageText { get { return messageText; } }
        public int? RespondsToId { get { return respondsToId; } }
        public string Topic { get { return topic; } }

        //DB Access

        //Insert
        //Inserts the message into the DB
        //Returns 1 on success
        public int Insert(SqlConnection connection)
        {
            return DBMessages.Insert(connection, userEmail, creationDate, messageText, respondsToId, topic);
        }

        //Delete
        //Deletes the message from the DB
        //Returns 1 on success
        public int Delete(SqlConnection connection)
        {
            return DBMessages.Delete(connection, id);
        }

        //Modify
        //Updates the values of the user with the same email
        //Returns 1 on success
        public int Modify(SqlConnection connection)
        {
            return DBMessages.Modify(connection, id, userEmail, creationDate, messageText, respondsToId, topic);
        }

        //Read
        //Returns a list of messages from the DB
        public List<Message> Read(SqlConnection connection)
        {
            List<Message> messages = new List<Message>();
            SqlDataReader reader = DBMessages.Read(connection);
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

                messages.Add(new Message(nId, nUserEmail, nCreationDate, nMessageText, nRespondsToId, nTopic));
            }

            reader.Close();
            return messages;
        }

        //Responses
        //Returns every message responding to this one
        public List<Message> Responses(SqlConnection connection)
        {
            List<Message> messages = new List<Message>();
            SqlDataReader reader = DBMessages.Read(connection, id);
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

                messages.Add(new Message(nId, nUserEmail, nCreationDate, nMessageText, nRespondsToId, nTopic));
            }

            reader.Close();
            return messages;
        }

        public List<Message> TopicMessages(SqlConnection connection, string topic)
        {
            List<Message> messages = new List<Message>();
            SqlDataReader reader = DBMessages.ReadTopic(connection, topic);
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

                messages.Add(new Message(nId, nUserEmail, nCreationDate, nMessageText, nRespondsToId, nTopic));
            }

            reader.Close();
            return messages;
        }

        public List<string> Topics(SqlConnection connection)
        {
            List<string> topics = new List<string>();
            SqlDataReader reader = DBMessages.Topics(connection);
            if (reader == null) return null;
            while (reader.Read())
            {
                string nTopic;
                if (reader["topic"] == DBNull.Value) nTopic = null;
                else nTopic = (string)reader["topic"];
                topics.Add(nTopic);
            }
            reader.Close();
            return topics;
        }

        public User Author(SqlConnection connection)
        {
            User user = null;
            SqlDataReader reader = DBMessages.Author(connection, userEmail);
            if (reader == null) return null;

            reader.Read();
            string nEmail, nUsername, nPassword, nFirstName, nLastName;
            nEmail = (string)reader["email"];
            nUsername = (string)reader["username"];
            nPassword = (string)reader["password"];
            nFirstName = (string)reader["firstName"];
            if (reader["lastName"] == DBNull.Value) nLastName = null;
            else nLastName = (string)reader["lastName"];
            user = new User(nEmail, nUsername, nPassword, nFirstName, nLastName);

            return user;
        }

    }
}
