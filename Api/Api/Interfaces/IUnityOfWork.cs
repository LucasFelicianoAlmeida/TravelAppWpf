﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IUnityOfWork
    {
        ICountry CountryRepository { get; }
        void Commit();
    }
}
