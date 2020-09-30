using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
	public class EventoRepository
	{

        private MySqlConnection Connect()
        {
            {
                string connString = "Server-127.0.0.1;Port=3306;Database=apuestas;Uid=root;password=your_password;SslMode=none";
                MySqlConnection con = new MySqlConnection(connString);
				return con;
            }
        }

        internal Evento Retrieve()
		{
			MySqlConnection con = Connect();
			MySqlCommand command = con.CreateCommand();
			command.CommandText = "select * from evento";

			con.Open();
			MySqlDataReader res = command.ExecuteReader();

			Evento e = null;
			if(res.Read())
            {
				Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetDateTime(2) + " " + res.GetInt32(3));
				e = new Evento(res.GetString(0), res.GetString(1), res.GetDateTime(2), res.GetInt32(3));
            }

			return e;
		}


	}
}