using System.Collections.Generic;

namespace ExcerciseASP.Models
{
    public class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Address>();
        }

        public string AddressTypeId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}