using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Apuesta
    {
        public Apuesta(int iD, int tipo, int cuota, int dineroApuesta, DateTime fecha, string usuario)
        {
            ID = iD;
            Tipo = tipo;
            Cuota = cuota;
            DineroApuesta = dineroApuesta;
            Fecha = fecha;
            Usuario = usuario;
        }

        public int ID { get; set; }
        public int Tipo { get; set; }
        public int Cuota { get; set; }
        public int DineroApuesta { get; set; }
        public DateTime Fecha { get; set; }
        public String Usuario { get; set; }
    }
}