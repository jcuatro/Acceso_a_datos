using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
    public class UsuarioRepository
    {

        private MySqlConnection Connect()
        {
            {
                string connString = "Server-127.0.0.1;Port=3306;Database=apuestas;Uid=root;password=your_password;SslMode=none";
                MySqlConnection con = new MySqlConnection(connString);
                return con;
            }
        }

        internal Usuario Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from usuario";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Usuario u = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt11(3));
                u = new Evento(res.GetString(0), res.GetString(1), res.GetDateTime(2), res.GetInt32(3));
            }

            return u;
        }
    }
}