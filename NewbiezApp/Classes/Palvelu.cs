using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Palvelu
    {
        public Palvelu()
        {
            VarauksenPalveluts = new HashSet<VarauksenPalvelut>();
        }

        public long PalveluId { get; set; }
        public long AlueId { get; set; }
        public string? Nimi { get; set; }
        public long? Tyyppi { get; set; }
        public string? Kuvaus { get; set; }
        public double Hinta { get; set; }
        public double Alv { get; set; }

        public virtual Alue Alue { get; set; } = null!;
        public virtual ICollection<VarauksenPalvelut> VarauksenPalveluts { get; set; }
    }
}
