using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class VarauksenPalvelut
    {
        public long VarausId { get; set; }
        public long PalveluId { get; set; }
        public long Lkm { get; set; }

        public virtual Palvelu Palvelu { get; set; } = null!;
        public virtual Varaus Varaus { get; set; } = null!;
    }
}
