using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Context
{
    public partial class Flight
    {
        public int Id { get; set; }
        public int IdRegion { get; set; }
        public double Price { get; set; }
        public double? LastPrice { get; set; }

        public virtual Region IdRegionNavigation { get; set; }
    }
}
