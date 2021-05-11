using MySql.Data.MySqlClient;
using PuertaMagica.DAL.Contracts;
using PuertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertaMagica.DAL.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public ConcesionarioContext context { get; set; }
        public UsuarioRepository(ConcesionarioContext context)
        {
            this.context = context;
        }
        public void Insertar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "INSERT INTO Usuarios (username,password) VALUES (@username,@password)";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.Password);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");
                
        }

        public void Actualizar(Usuario usuario)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "UPDATE usuarios SET password = @password WHERE username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.Password);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error updating data into Database!");
        }

        public void Delete(string username)
        {
            MySqlConnection conn = context.GetConnection();

            string query = "DELETE FROM usuarios WHERE username = @username";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@username", username);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error updating data into Database!");
        }
    }
}
