using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Mokki
    {
        public Mokki()
        {
            Varaus = new HashSet<Varaus>();
        }

        public long MokkiId { get; set; }
        public long AlueId { get; set; }
        public string Postinro { get; set; } = null!;
        public string? Mokkinimi { get; set; }
        public string? Katuosoite { get; set; }
        public double Hinta { get; set; }
        public string? Kuvaus { get; set; }
        public long? Henkilomaara { get; set; }
        public string? Varustelu { get; set; }

        public virtual Alue Alue { get; set; } = null!;
        public virtual Posti PostinroNavigation { get; set; } = null!;
        public virtual ICollection<Varaus> Varaus { get; set; }
    }
}
