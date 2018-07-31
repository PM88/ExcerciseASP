using System.Collections.Generic;

namespace ExcerciseASP.Models
{
    public class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
        }

        public string CustomerId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        
    }
}