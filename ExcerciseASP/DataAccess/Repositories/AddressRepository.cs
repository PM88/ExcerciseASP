using ExcerciseASP.Models;
using ExcerciseASP.Interfaces;
using System;
using System.Data.Entity.Validation;

namespace ExcerciseASP.DataAccess.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationContext context) : base(context)
        {
        }

        public void Update(Address entry)
        {
            try
            {
                if (entry == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Address existing = base.Get(entry.CustomerId, entry.AddressTypeId);

                Context.Entry(existing).CurrentValues.SetValues(entry);
                Context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw new Exception(errorMessage, dbEx);
            }
        }
    }
}