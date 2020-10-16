using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Evento
    {
        public Evento(int iD, string equipoLocal, string equipoVisitante, DateTime fecha)
        {
            ID = iD;
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            Fecha = fecha;
        }

        public int ID { get; set; }
        public String EquipoLocal { get; set; }
        public String EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }
    }
}