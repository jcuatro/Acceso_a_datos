﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class MercadoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal Mercado Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from mercado";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Mercado m = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + " " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3)+ " " + res.GetDouble(4)+ " "+ res.GetInt32(5));
                m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetInt32(5));
            }

            return m;
        }


    }
}