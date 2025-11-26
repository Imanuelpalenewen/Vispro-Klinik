using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    // Helper static class untuk koneksi Database dan utility.
    public static class Database
    {
        // Sesuaikan connection string di sini jika perlu.
        public static string ConnectionString = "server=localhost;user id=root;password=Vyd18Tjia12;database=klinik_db;";

        // Mengembalikan MySqlConnection yang sudah terbuka.
        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnectionString);
            return conn;
        }

        // Utility untuk mengeksekusi non-query (INSERT/UPDATE/DELETE)
        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Utility untuk mendapatkan MySqlDataReader (caller harus dispose reader & connection jika digunakan).
        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] parameters)
        {
            var conn = GetConnection();
            conn.Open();
            var cmd = new MySqlCommand(sql, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            // Caller harus menutup reader (which will close connection if CommandBehavior.CloseConnection used)
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}
