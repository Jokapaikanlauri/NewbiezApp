using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Asiakas
    {
        public Asiakas()
        {
            Varaus = new HashSet<Varaus>();
        }

        public long AsiakasId { get; set; }
        public string Postinro { get; set; } = null!;
        public string? Etunimi { get; set; }
        public string? Sukunimi { get; set; }
        public string? Lahiosoite { get; set; }
        public string? Email { get; set; }
        public string? Puhelinnro { get; set; }

        public virtual Posti PostinroNavigation { get; set; } = null!;
        public virtual ICollection<Varaus> Varaus { get; set; }
    }
}
