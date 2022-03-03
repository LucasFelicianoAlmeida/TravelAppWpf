using System;
using System.Collections.Generic;

#nullable disable

namespace TravelApp.MVVM.Model
{
    public partial class FavCountry
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string CountryCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
