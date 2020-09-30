using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Place_my_bet.Models
{
    public class Mercado
    {
        public int OverUnder { get; set; }
        public int Cuota_over { get; set; }
        public int Cuota_under { get; set; }
        public int Dinero_over { get; set; }
        public int Dinero_under { get; set; }
        public int Partido { get; set; }
        public Mercado(int over_under, int Cuota_over, int Cuota_under, int Dinero_over, int Dinero_under, int Partido)
        {
            this.OverUnder = OverUnder;
            this.Cuota_over = Cuota_over;
            this.Cuota_under = Cuota_under;
            this.Dinero_over = Dinero_over;
            this.Dinero_under = Dinero_under;
            this.Partido = Partido;
    }

    }
}