using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Core.Services
{
    class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(connectionString);
            return conn;
        }
        public void ExecuteNonQuery (string query, params NpgsqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveMessage(string sender, string receiver, string message)
        {
            string query = "INSERT INTO messages (sender, receiver, message) VALUES (@sender, @receiver, @message)";
            ExecuteNonQuery(query,
                new NpgsqlParameter("@sender", sender),
                new NpgsqlParameter("@sender", receiver),
                new NpgsqlParameter("@message", message));
        }
    }
}
