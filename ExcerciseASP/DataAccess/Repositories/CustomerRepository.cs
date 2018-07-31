using ExcerciseASP.Models;
using ExcerciseASP.Interfaces;
using System;
using System.Data.Entity.Validation;

namespace ExcerciseASP.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext context) : base(context)
        {
        }
    }
}