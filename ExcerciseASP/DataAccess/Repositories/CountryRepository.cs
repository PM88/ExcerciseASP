using ExcerciseASP.Models;
using ExcerciseASP.Interfaces;

namespace ExcerciseASP.DataAccess.Repositories
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationContext context) : base(context)
        {
        }
    }
}