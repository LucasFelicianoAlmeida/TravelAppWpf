using System;
using System.Collections.Generic;

#nullable disable

namespace TravelApp.MVVM.Model
{
    public partial class Country
    {
        public Country()
        {
            FavCountries = new HashSet<FavCountry>();
            Regions = new HashSet<Region>();
        }

        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public CountryEnum Status { get; set; } = CountryEnum.Far;

        public virtual ICollection<FavCountry> FavCountries { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }

    public enum CountryEnum
    {
        Vazio,
        Selected,
        Near,
        Far
    }
}
