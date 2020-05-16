using Ekart.Models;
using Ekart.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult<List<Customers>> Get() =>
            _customerService.Get();

        [HttpGet("{id:length(24)}",Name ="GetCustomer")]
        public ActionResult<Customers> Get(string id)
        {
            var customer = _customerService.Get(id);

            if(customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpPost]
        public ActionResult<Customers> Create(Customers customer)
        {
            _customerService.Create(customer);
            return CreatedAtRoute("GetCustomer", new { id = customer.Id.ToString() }, customer);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Customers customerIn)
        {
            var customer = _customerService.Get(id);
            if(customer == null)
            {
                return NotFound();
            }
            _customerService.Update(id, customerIn);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var customer = _customerService.Get(id);
            if(customer == null)
            {
                return NotFound();
            }
            _customerService.Remove(id);

            return NoContent();
        }
    }

}
