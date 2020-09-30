﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
	public class ApuestaRepository
	{

		private MySqlConnection Connect()
		{
			{
				string connString = "Server-127.0.0.1;Port=3306;Database=apuestas;Uid=root;password=your_password;SslMode=none";
				MySqlConnection con = new MySqlConnection(connString);
				return con;
			}
		}

		internal Apuesta Retrieve()
		{
			MySqlConnection con = Connect();
			MySqlCommand command = con.CreateCommand();
			command.CommandText = "select * from apuesta";

			con.Open();
			MySqlDataReader res = command.ExecuteReader();

			Apuesta a = null;
			if (res.Read())
			{
				Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetInt32(2) + " " + res.GetInt32(3) + " " + res.GetDateTime(4) + " " + res.GetString(5));
				a = new Apuesta(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3), res.GetDateTime(4), res.GetString(5));
			}

			return a;
		}


	}
}