using System;
using System.Collections.Generic;

namespace NewbiezApp.Classes
{
    public partial class Lasku
    {
        public long LaskuId { get; set; }
        public long VarausId { get; set; }
        public double Summa { get; set; }
        public double Alv { get; set; }
        public string? Tila { get; set; }
        public virtual Varaus Varaus { get; set; } = null!;
    }
}
