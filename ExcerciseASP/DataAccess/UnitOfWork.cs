using ExcerciseASP.Interfaces;
using ExcerciseASP.DataAccess.Repositories;

namespace ExcerciseASP.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Addresses = new AddressRepository(_context);
            Customers = new CustomerRepository(_context);
            Countries = new CountryRepository(_context);
        }

        public IAddressRepository Addresses { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public ICountryRepository Countries { get; private set; }
        private readonly ApplicationContext _context;

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}