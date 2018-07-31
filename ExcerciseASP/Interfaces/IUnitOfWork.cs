using System;
using ExcerciseASP.DataAccess.Repositories;
using ExcerciseASP.DataAccess;

namespace ExcerciseASP.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        ICustomerRepository Customers { get; }
        ICountryRepository Countries { get; }
        int Complete();
    }
}