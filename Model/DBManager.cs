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
                                             ORDER BY messages.sent_at ASC";

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
                    command.Parameters.AddWithValue("@sentAt", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        } 

        public List<Message> GetNewMessages(long userId, long chatRoomId)
        {
            List<Message> newMessages = new List<Message>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT m.id, m.chat_room_id, m.sender_id, m.message_text, m.sent_at
                         FROM messages m
                         INNER JOIN conversation_participants cp ON m.chat_room_id = cp.chat_room_id
                         WHERE cp.user_id = @userId AND m.chat_room_id = @chatRoomId AND m.sent_at > (
                             SELECT COALESCE(MAX(cm.last_checked), '2000-01-01') -- Assuming a default date for initial checking
                             FROM chatroom_metadata cm
                             WHERE cm.chat_room_id = m.chat_room_id AND cm.user_id = @userId
                         )";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@chatRoomId", chatRoomId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message
                            {
                                Sender = GetUser(reader.GetInt32("sender_id")),
                                Content = reader.GetString("message_text"),
                                Timestamp = reader.GetDateTime("sent_at")
                            };

                            newMessages.Add(message);
                        }
                    }
                }

                if (newMessages.Count > 0)
                {
                    string updateQuery = @"INSERT INTO chatroom_metadata (user_id, chat_room_id, last_checked)
                                   VALUES (@userId, @chatRoomId, NOW())
                                   ON DUPLICATE KEY UPDATE last_checked = NOW()";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@userId", userId);
                        updateCommand.Parameters.AddWithValue("@chatRoomId", chatRoomId);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }

            return newMessages;
        }
        public long CreateUser(string username, string password)
        {
            long userId = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO users (username, password) VALUES (@username, @password); SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    userId = Convert.ToInt64(command.ExecuteScalar());
                }
            }

            return userId;
        }

        public long get_last_chatroom_id()
        {
            long id = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(chat_room.id) FROM chat_room;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    id = Convert.ToInt64(command.ExecuteScalar());
                }
            }
            return id;
        }

        public long CreateChatRoom(string chatRoom_Name)
        {
            long chatRoomId = get_last_chatroom_id() + 1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO chat_room (id, name) VALUES (@last_id, @name);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", chatRoom_Name);
                    command.Parameters.AddWithValue("@last_id", chatRoomId);
                    command.ExecuteNonQuery();
                }
            }

            return chatRoomId;
        }

        private void AddUserToChatRoom(long userId, long chatRoomId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO conversation_participants (chat_room_id, user_id) VALUES (@chatRoomId, @userId);";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@chatRoomId", chatRoomId);
                    command.Parameters.AddWithValue("@userId", userId);
                    Console.WriteLine($"RES: {userId}, {chatRoomId}");
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddUser(string username, string password)
        {
            long userId = DBManager.Instance.CreateUser(username, password);
            long chatRoomId = DBManager.Instance.CreateChatRoom($"{username}'s Conversation");
            AddUserToChatRoom(userId, chatRoomId);
        }
    }
}
