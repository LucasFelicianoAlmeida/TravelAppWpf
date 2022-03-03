using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Context
{
    public partial class Region
    {
        public Region()
        {
            Flights = new HashSet<Flight>();
            ImageRegions = new HashSet<ImageRegion>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Place { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<ImageRegion> ImageRegions { get; set; }
    }
}
