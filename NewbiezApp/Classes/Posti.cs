using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Posti
    {
        public Posti()
        {
            Asiakas = new HashSet<Asiakas>();
            Mokkis = new HashSet<Mokki>();
        }

        public string Postinro { get; set; } = null!;
        public string? Toimipaikka { get; set; }

        public virtual ICollection<Asiakas> Asiakas { get; set; }
        public virtual ICollection<Mokki> Mokkis { get; set; }
    }
}
