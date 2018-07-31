using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ExcerciseASP.DataAccess;
using ExcerciseASP.Models;
using ExcerciseASP.Models.Services;
using ExcerciseASP.Interfaces;

namespace ExcerciseASP.Controllers.API
{
    public class AddressesController : ApiController
    {
        private IAddressService _service;

        public AddressesController()
        {
            _service = new AddressService(this.ModelState);
        }

        // GET: api/Addresses
        public IEnumerable<Address> GetAddresses()
        {
            return _service.ListEntries();
        }

        // GET: api/Addresses/{customerId}/AddressType/{addressTypeId}
        [ResponseType(typeof(Address))]
        public IHttpActionResult GetAddress(string customerId, string addressTypeId)
        {
            Address address = _service.GetEntry(customerId, addressTypeId);
            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        // PUT: api/Addresses/
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAddress(Address address)
        {
            switch (_service.ModifyEntry(address))
            {
                case 0:
                    return StatusCode(HttpStatusCode.OK);
                case 1:
                    return StatusCode(HttpStatusCode.NotFound);
                default:
                    return StatusCode(HttpStatusCode.BadRequest);
            }
        }

        // POST: api/Addresses
        [ResponseType(typeof(Address))]
        public IHttpActionResult PostAddress(Address address)
        {
            switch (_service.CreateEntry(address))
            {
                case 0:
                    return StatusCode(HttpStatusCode.OK);
                case 1:
                    return StatusCode(HttpStatusCode.Conflict);
                default:
                    return StatusCode(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Addresses/{customerId}/AddressType/{addressTypeId}
        [ResponseType(typeof(Address))]
        public IHttpActionResult DeleteAddress(string customerId, string addressTypeId)
        {
            Address address = _service.GetEntry(customerId, addressTypeId);
            if (address == null)
            {
                return NotFound();
            }

            if (!(_service.RemoveEntry(address)))
                return StatusCode(HttpStatusCode.BadRequest);
            
            return StatusCode(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}