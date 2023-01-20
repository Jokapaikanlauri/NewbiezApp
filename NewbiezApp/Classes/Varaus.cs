using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Varaus
    {
        public Varaus()
        {
            Laskus = new HashSet<Lasku>();
            VarauksenPalveluts = new HashSet<VarauksenPalvelut>();
        }

        public long VarausId { get; set; }
        public long AsiakasId { get; set; }
        public long MokkiMokkiId { get; set; }

        public DateTime? VarattuPvm { get; set; }
        public DateTime? VahvistusPvm { get; set; }
        public DateTime? VarattuAlkupvm { get; set; }
        public DateTime? VarattuLoppupvm { get; set; }

        public virtual Asiakas Asiakas { get; set; } = null!;
        public virtual Mokki MokkiMokki { get; set; } = null!;
        public virtual ICollection<Lasku> Laskus { get; set; }
        public virtual ICollection<VarauksenPalvelut> VarauksenPalveluts { get; set; }


        

    }
}
