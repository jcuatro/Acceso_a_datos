using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
	public class Evento
	{
        public string equipo_local { get; set; }
        public string equipo_visitante { get; set; }
        public DateTime fecha { get; set; }
        public int id { get; set; }
        public Evento(string equipo_local, string equipo_visitante, DateTime fecha, int id)
        {
            this.equipo_local = equipo_local;
            this.equipo_visitante = equipo_visitante;
            this.fecha = fecha;
            this.id = id;
        }

    }
}