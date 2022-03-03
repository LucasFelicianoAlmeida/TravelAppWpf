using System;
using System.Collections.Generic;

#nullable disable

namespace TravelApp.MVVM.Model
{
    public partial class User
    {
        public User()
        {
            FavCountries = new HashSet<FavCountry>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<FavCountry> FavCountries { get; set; }
    }
}
