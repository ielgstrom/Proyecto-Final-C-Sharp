using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.DAL
{
    public static class DBMessages
    {
        //INSERT
        //Inserts a row into Messages
        public static int Insert(SqlConnection connection, string userEmail, DateTime creationDate, string messageText, int? respondsToId, string topic)
        {
            int control = 0;

            //Create the query and the sql command
            string query = @"INSERT INTO Messages (userEmail, creationDate, messageText, respondsToId, topic)
                            VALUES (@pUserEmail, @pCreationDate, @pMessageText, @pRespondsToId, @pTopic)";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pUserEmail = new SqlParameter("@pUserEmail", System.Data.SqlDbType.NVarChar, 320);
            pUserEmail.Value = userEmail;

            SqlParameter pCreationDate = new SqlParameter("@pCreationDate", System.Data.SqlDbType.DateTime);
            pCreationDate.Value = creationDate;

            SqlParameter pMessageText = new SqlParameter("@pMessageText", System.Data.SqlDbType.NVarChar, 1000);
            pMessageText.Value = messageText;

            SqlParameter pRespondsToId = new SqlParameter("@pRespondsToId", System.Data.SqlDbType.Int);
            if (respondsToId.HasValue) pRespondsToId.Value = respondsToId;
            else pRespondsToId.Value = DBNull.Value;

            SqlParameter pTopic = new SqlParameter("@pTopic", System.Data.SqlDbType.NVarChar, 50);
            if (topic == null) pTopic.Value = DBNull.Value;
            else pTopic.Value = topic;

            //Add sql parameters
            command.Parameters.Add(pUserEmail);
            command.Parameters.Add(pCreationDate);
            command.Parameters.Add(pMessageText);
            command.Parameters.Add(pRespondsToId);
            command.Parameters.Add(pTopic);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //DELETE
        //Deletes a row from Messages
        //Uses primary key as identifier
        public static int Delete(SqlConnection connection, int primaryKey)
        {
            int control = 0;

            //Create the query and the sql command
            string query = "DELETE FROM Messages WHERE id = @pId";
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
        public static int Modify(SqlConnection connection, int primaryKey, string userEmail, DateTime creationDate, string messageText, int? respondsToId, string topic)
        {
            int control = 0;

            //Create the query and the sql command
            string query = @"UPDATE Messages SET
                            userEmail = @pUserEmail, creationDate = @pCreationDate, messageText = @pMessageText, respondsToId = @pRespondsToId, topic = @pTopic
                            WHERE id = @pId";

            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pId = new SqlParameter("@pId", System.Data.SqlDbType.Int);
            pId.Value = primaryKey;

            SqlParameter pUserEmail = new SqlParameter("@pUserEmail", System.Data.SqlDbType.NVarChar, 320);
            pUserEmail.Value = userEmail;

            SqlParameter pCreationDate = new SqlParameter("@pCreationDate", System.Data.SqlDbType.DateTime);
            pCreationDate.Value = creationDate;

            SqlParameter pMessageText = new SqlParameter("@pMessageText", System.Data.SqlDbType.NVarChar, 1000);
            pMessageText.Value = messageText;

            SqlParameter pRespondsToId = new SqlParameter("@pRespondsToId", System.Data.SqlDbType.Int);
            if (respondsToId.HasValue) pRespondsToId.Value = respondsToId;
            else pRespondsToId.Value = DBNull.Value;

            SqlParameter pTopic = new SqlParameter("@pTopic", System.Data.SqlDbType.NVarChar, 50);
            if (topic == null) pTopic.Value = DBNull.Value;
            else pTopic.Value = topic;

            //Add sql parameters
            command.Parameters.Add(pId);
            command.Parameters.Add(pUserEmail);
            command.Parameters.Add(pCreationDate);
            command.Parameters.Add(pMessageText);
            command.Parameters.Add(pRespondsToId);
            command.Parameters.Add(pTopic);

            //Execute query
            control = command.ExecuteNonQuery();

            return control;
        }

        //READ
        //Reads all rows from Messages
        public static SqlDataReader Read(SqlConnection connection)
        {
            string query = "SELECT * FROM Messages";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //READ
        //Reads all messages from a certain user
        public static SqlDataReader Read(SqlConnection connection, string userEmail)
        {
            string query = "SELECT * FROM Messages WHERE userEmail = @pUserEmail";
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

        //READ
        //Reads all messages responding to a certain message
        public static SqlDataReader Read(SqlConnection connection, int messageId)
        {
            string query = "SELECT * FROM Messages WHERE respondsToId = @pRespondsToId";
            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pRespondsToId = new SqlParameter("@pRespondsToId", System.Data.SqlDbType.Int);
            pRespondsToId.Value = messageId;

            //Add sql parameters
            command.Parameters.Add(pRespondsToId);

            //Execute query
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //READ
        //Reads all messages from a certain topic
        public static SqlDataReader ReadTopic(SqlConnection connection, string topic)
        {
            string query = "SELECT * FROM Messages WHERE topic = @pTopic";
            SqlCommand command = new SqlCommand(query, connection);

            //Create sql parameters
            SqlParameter pTopic = new SqlParameter("@pTopic", System.Data.SqlDbType.NVarChar, 50);
            if (topic == null) pTopic.Value = DBNull.Value;
            else pTopic.Value = topic;

            //Add sql parameters
            command.Parameters.Add(pTopic);

            //Execute query
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }


    }
}