using System.Collections.Generic;

namespace ExcerciseASP.Models
{
    public class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
        }

        public string CountryCode { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

    }
}