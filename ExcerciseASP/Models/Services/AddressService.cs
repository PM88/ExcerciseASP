using System.Collections.Generic;
using ExcerciseASP.Interfaces;
using ExcerciseASP.DataAccess;
using System.Web.Http.ModelBinding;

namespace ExcerciseASP.Models.Services
{
    public class AddressService : IAddressService
    {
        private ModelStateDictionary _modelState;
        private IUnitOfWork UoW;

        public AddressService(ModelStateDictionary modelState)
        {
            UoW = new UnitOfWork(new ApplicationContext());
            _modelState = modelState;
        }

        protected bool ValidateAddress(Address addressToValidate)
        {
            if (addressToValidate.CustomerId.Length == 0)
                _modelState.AddModelError("CustomerId", "CustomerId is required.");
            if (addressToValidate.CustomerId.Length > 5)
                _modelState.AddModelError("CustomerId", "CustomerId can be max 5 characters long.");
            switch (addressToValidate.AddressTypeId)
            {
                case "I":
                case "D":
                case "S":
                    break;
                default:
                    _modelState.AddModelError("AddressTypeId", "Address is required to be either I, D or S.");
                break;
            }
            if (addressToValidate.Name.Length == 0)
                _modelState.AddModelError("Name", "Customer name is required.");
            if (addressToValidate.Name.Length > 100)
                _modelState.AddModelError("Name", "Customer name can be max 100 characters long.");

            //Optional fields
            if (!(addressToValidate.Street == null))
                if (addressToValidate.Street.Length > 100)
                    _modelState.AddModelError("Street", "Street can be max 100 characters long.");

            if(!(addressToValidate.ZIP == null))
                if (addressToValidate.ZIP.Length > 20)
                    _modelState.AddModelError("ZIP", "ZIP can be max 20 characters long.");

            if (!(addressToValidate.City == null))
                if (addressToValidate.City.Length > 100)
                    _modelState.AddModelError("City", "City can be max 100 characters long.");

            if (!(addressToValidate.CountryCode == null))
                if (UoW.Countries.Get(addressToValidate.CountryCode)==null)
                    _modelState.AddModelError("Country", "Country code must follow ISO 3166-2");

            return _modelState.IsValid;
        }

        public IEnumerable<Address> ListEntries()
        {
            return UoW.Addresses.GetAll();
        }

        public byte CreateEntry(Address entry)
        {
            if (!ValidateAddress(entry))
                return 2;

            if (AddressExists(entry.CustomerId, entry.AddressTypeId))
                return 1;

            try
            {
                UoW.Addresses.Add(entry);
            }
            catch
            {
                return 3;
            }

            return 0;
        }

        public Address GetEntry(string customerId, string addressTypeId)
        {
            Address address = UoW.Addresses.Get(customerId, addressTypeId);
            return address;
        }

        public bool RemoveEntry(Address entry)
        {
            try
            {
                UoW.Addresses.Remove(entry);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public byte ModifyEntry(Address entry)
        {
            if (!ValidateAddress(entry))
                return 2;

            if (!(AddressExists(entry.CustomerId, entry.AddressTypeId)))
            {
                _modelState.AddModelError("Not Found", "Address with this Customer ID and Address type was not found in the database.");
                return 1;
            }

            try
            {
                UoW.Addresses.Update(entry);
            }
            catch
            {
                return 3;
            }

            return 0;
        }

        private bool AddressExists(string customerId, string addressTypeId)
        {
            return !(UoW.Addresses.Get(customerId, addressTypeId) == null);
        }

        public void Dispose()
        {
            UoW.Dispose();
        }
    }
}