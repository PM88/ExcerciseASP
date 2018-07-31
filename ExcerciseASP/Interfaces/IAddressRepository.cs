using ExcerciseASP.Models;

namespace ExcerciseASP.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        void Update(Address entry);
    }
}