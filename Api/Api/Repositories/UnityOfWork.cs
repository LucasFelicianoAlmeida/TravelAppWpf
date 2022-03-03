using Api.Context;
using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly TravelDbContext _context;
        public UnityOfWork(TravelDbContext context)
        {
            _context = context;
        }

        private CountryRepository _countryRepository;
        public ICountry CountryRepository
        {
            get
            {
                return _countryRepository = _countryRepository ?? new CountryRepository(_context);
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

    }
}
