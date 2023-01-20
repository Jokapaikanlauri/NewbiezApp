using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Alue
    {
        public Alue()
        {
            Mokkis = new HashSet<Mokki>();
            Palvelus = new HashSet<Palvelu>();
        }

        public long AlueId { get; set; }
        public string? Nimi { get; set; }

        public virtual ICollection<Mokki> Mokkis { get; set; }
        public virtual ICollection<Palvelu> Palvelus { get; set; }
    }
}
