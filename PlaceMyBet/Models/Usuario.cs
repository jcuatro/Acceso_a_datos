using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public Usuario(string equipo_local, string equipo_visitante, DateTime fecha, int id)
        {
            this.Email = Email;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
        }
    }
}