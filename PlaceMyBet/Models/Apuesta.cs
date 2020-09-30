using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
    public class Apuesta
    {
        public int ID { get; set; }
        public int Tipo { get; set; }
        public int Cuota { get; set; }
        public int Dinero_apuesta { get; set; }
        public DateTime fecha { get; set; }
        public string Usuario { get; set; }
        public Apuesta(int ID, int Tipo, int Cuota, int Dinero_apuesta, DateTime fecha, string Usuario)
        {
            this.ID = ID;
            this.Tipo = Tipo;
            this.Cuota = Cuota;
            this.Dinero_apuesta = Dinero_apuesta;
            this.fecha = fecha;
            this.Usuario = Usuario;
        }

    }
}