using System.Collections.Generic;

namespace ExcerciseASP.Models
{
    public class Address
    {
        public virtual Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }

        public virtual AddressType AddressType { get; set; }
        public string AddressTypeId { get; set; }

        public string Street { get; set; }

        public string ZIP { get; set; }

        public string City { get; set; }

        public virtual Country CountryClass { get; set; }
        public string CountryCode { get; set; }
    }
}