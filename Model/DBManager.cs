using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace Cress.Model
{
    public class DBManager
    {
        private static DBManager instance;
        private static readonly object lockObject = new object();
        private readonly string connectionString;

        // Private constructor to prevent external instantiation
        private DBManager()
        {
            // Initialize database connection string
            connectionString = "datasource=127.0.0.1;username=root;password=;database=cress;";
        }

        // Public static property to access the singleton instance
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new DBManager();
                        }
                    }
                }
                return instance;
            }
        }

        // Public method to execute database queries
        public void ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public long ExecuteQueryGetCount(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    return (long)command.ExecuteScalar();
                }
            }
        }

        public Model.User GetUser(long id)
        {
            Model.User user = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE users.id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User()
                            {
                                Id = (int)reader["id"],
                                Username = (string)reader["username"]
                            };
                        }
                    }
                }
            }
            return user;
        }

        public Model.User GetUser(string username, string password)
        {
            Model.User user = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE users.password = @password and users.username = @username;", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User()
                            {
                                Id = (int)reader["id"],
                                Username = (string)reader["username"]
                            };
                        }
                    }
                }
            }
            return user;
        }

        public List<ChatRoom> GetChatRoomsByUserID(long userId)
        {
            List<ChatRoom> chatRooms = new List<ChatRoom>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string chatRoomQuery = @"SELECT cr.id, cr.name 
                                     FROM chat_room cr 
                                     INNER JOIN conversation_participants cp ON cr.id = cp.chat_room_id
                                     WHERE cp.user_id = @userId
                                     ORDER BY (
                                         SELECT MAX(m.sent_at)
                                         FROM messages m
                                         WHERE m.chat_room_id = cr.id
                                     ) DESC";

                using (MySqlCommand chatRoomCommand = new MySqlCommand(chatRoomQuery, connection))
                {
                    chatRoomCommand.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader chatRoomReader = chatRoomCommand.ExecuteReader())
                    {
                        while (chatRoomReader.Read())
                        {
                            ChatRoom chatRoom = new ChatRoom
                            {
                                Id = chatRoomReader.GetInt32(0),
                                Name = chatRoomReader.GetString(1),
                                Messages = new List<Message>(),
                                Participants = new List<User>()
                            };

                            chatRooms.Add(chatRoom);
                        }
                    }
                }

                foreach (ChatRoom chatRoom in chatRooms)
                {
                    string messageQuery = @"SELECT id, chat_room_id, sender_id, message_text, sent_at
                                             FROM messages
                                             WHERE chat_room_id = @chatRoomId
                                             ORDER BY messages.sent_at DESC";

                    using (MySqlCommand messageCommand = new MySqlCommand(messageQuery, connection))
                    {
                        messageCommand.Parameters.AddWithValue("@chatRoomId", chatRoom.Id);

                        using (MySqlDataReader messageReader = messageCommand.ExecuteReader())
                        {
                            while (messageReader.Read())
                            {
                                Message message = new Message
                                {
                                    Sender = GetUser(messageReader.GetInt32("sender_id")),
                                    Content = messageReader.GetString("message_text"),
                                    Timestamp = messageReader.GetDateTime("sent_at")
                                };

                                chatRoom.Messages.Add(message);
                            }
                        }
                    }

                    string participantQuery = @"SELECT u.id, u.username, u.password
                                             FROM users u
                                             INNER JOIN conversation_participants cp ON u.id = cp.user_id
                                             WHERE cp.chat_room_id = @chatRoomId";

                    using (MySqlCommand participantCommand = new MySqlCommand(participantQuery, connection))
                    {
                        participantCommand.Parameters.AddWithValue("@chatRoomId", chatRoom.Id);

                        using (MySqlDataReader participantReader = participantCommand.ExecuteReader())
                        {
                            while (participantReader.Read())
                            {
                                User participant = new User
                                {
                                    Id = participantReader.GetInt32(0),
                                    Username = participantReader.GetString(1),
                                };

                                chatRoom.Participants.Add(participant);
                            }
                        }
                    }
                }
            }

            return chatRooms;
        }

        public void SendMessage(Model.ChatRoom chatRoom, Model.User sender, string message)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO messages (chat_room_id, sender_id, message_text, sent_at)
                             VALUES (@chatRoomId, @senderId, @messageText, @sentAt)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@chatRoomId", chatRoom.Id);
                    command.Parameters.AddWithValue("@senderId", sender.Id);
                    command.Parameters.AddWithValue("@messageText", message);
                    command.Parameters.AddWithValue("@sentAt", DateTime.UtcNow);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
