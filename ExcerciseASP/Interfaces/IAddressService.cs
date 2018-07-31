using System.Collections.Generic;
using ExcerciseASP.Models;

namespace ExcerciseASP.Interfaces
{
    public interface IAddressService
    {
        byte CreateEntry(Address entry);
        Address GetEntry(string customerId, string addressTypeId);
        IEnumerable<Address> ListEntries();
        bool RemoveEntry(Address entry);
        byte ModifyEntry(Address entry);
        void Dispose();
    }
}