using System.Collections.Generic;

namespace ExcerciseASP.Models.Services
{
    public interface ICustomerService
    {
        byte CreateEntry(Customer entry);
        Customer GetEntry(string customerId, string name);
        IEnumerable<Customer> ListEntries();
        bool RemoveEntry(Customer entry);
        void Dispose();
    }
}