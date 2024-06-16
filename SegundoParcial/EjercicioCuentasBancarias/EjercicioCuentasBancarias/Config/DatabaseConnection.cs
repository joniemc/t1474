using EjercicioCuentasBancarias.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.Config
{
    public class DatabaseConnection
    {
        string stringConnection = "Server=localhost;Database=clase_ejemplo_db;User Id=root;Password=root;";
        MySqlConnection connection; // Cambia a MySqlConnection

        public DatabaseConnection()
        {
            this.connection = new MySqlConnection(stringConnection); // Cambia a MySqlConnection
        }

        public void OpenConnection()
        {
            if (this.connection.State != System.Data.ConnectionState.Open)
            {
                this.connection.Open();
                Console.WriteLine("Conexión abierta");
            }
        }

        public void CloseConnection()
        {
            if (this.connection.State == System.Data.ConnectionState.Open)
            {
                this.connection.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }

        public List<Usuario> ExecuteSQL(string sql)
        { // Cambia a MySqlDataReader
            OpenConnection();
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand command = new MySqlCommand(sql, this.connection); // Cambia a MySqlCommand
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Usuario usuario = new Usuario(reader.GetString(0), reader.GetString(1));
                usuarios.Add(usuario);
            }
            CloseConnection();

            return usuarios;
        }

    }
}
