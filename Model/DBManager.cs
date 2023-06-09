using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    }
}
