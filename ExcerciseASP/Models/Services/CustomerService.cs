using System.Collections.Generic;
using ExcerciseASP.Interfaces;
using ExcerciseASP.DataAccess.Repositories;
using ExcerciseASP.DataAccess;
using System.Web.Http.ModelBinding;

namespace ExcerciseASP.Models.Services
{
    public class CustomerService : ICustomerService
    {
        private ModelStateDictionary _modelState;
        private IUnitOfWork UoW;

        public CustomerService(ModelStateDictionary modelState)
        {
            UoW = new UnitOfWork(new ApplicationContext());
            _modelState = modelState;
        }

        protected bool ValidateCustomer(Customer customerToValidate)
        {
            if (customerToValidate.CustomerId.Length == 0)
                _modelState.AddModelError("CustomerId", "CustomerId is required.");
            if (customerToValidate.CustomerId.Length > 5)
                _modelState.AddModelError("CustomerId", "CustomerId can be max 5 characters long.");
            if (customerToValidate.Name.Length == 0)
                _modelState.AddModelError("Name", "Name is required.");
            if (customerToValidate.Name.Length > 100)
                _modelState.AddModelError("Name", "Customer name can be max 100 characters long.");

            return _modelState.IsValid;
        }


        public IEnumerable<Customer> ListEntries()
        {
            return UoW.Customers.GetAll();
        }

        public byte CreateEntry(Customer entry)
        {
            if (!ValidateCustomer(entry))
                return 2;

            if (CustomerExists(entry.CustomerId, entry.Name))
                return 1;

            try
            {
                UoW.Customers.Add(entry);
            }
            catch
            {
                return 3;
            }

            return 0;
        }

        public Customer GetEntry(string customerId, string name)
        {
            Customer customer = UoW.Customers.Get(customerId, name);
            return customer;

        }

        public bool RemoveEntry(Customer entry)
        {
            try
            {
                UoW.Customers.Remove(entry);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private bool CustomerExists(string customerId, string name)
        {
            return !(UoW.Customers.Get(customerId, name) == null);
        }

        public void Dispose()
        {
            UoW.Dispose();
        }
    }
}