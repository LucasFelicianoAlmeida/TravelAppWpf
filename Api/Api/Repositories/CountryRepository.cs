using Api.Context;
using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class CountryRepository : Repository<Country>, ICountry
    {
        public CountryRepository(TravelDbContext context) : base(context)
        {
             
        }
    }
}
