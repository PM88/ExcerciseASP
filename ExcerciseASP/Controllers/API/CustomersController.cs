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

namespace ExcerciseASP.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ICustomerService _service;

        public CustomersController()
        {
            _service = new CustomerService(this.ModelState);
        }

        // GET: api/Customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _service.ListEntries();
        }

        // GET: api/Customers/{customerId}/Name/{name}
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomer(string customerId, string name)
        {
            Customer customer = _service.GetEntry(customerId, name);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST: api/Customers
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(Customer customer)
        {
            switch (_service.CreateEntry(customer))
            {
                case 0:
                    return StatusCode(HttpStatusCode.OK);
                case 1:
                    return StatusCode(HttpStatusCode.Conflict);
                default:
                    return StatusCode(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Customers/{customerId}/Name/{name}
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(string customerId, string name)
        {
            Customer customer = _service.GetEntry(customerId, name);
            if (customer == null)
            {
                return NotFound();
            }

            if (!(_service.RemoveEntry(customer)))
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