using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase {
        private static readonly Customer[] customers = new[]
        {
            new Customer{customerID=110, name="pepa",surname="novak"},
            new Customer{customerID=111, name="franta",surname="novak"},
            new Customer{customerID=112, name="josef",surname="novak"}
        };

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Customer> Get() {
            
            return customers.Select(c=>c)     .ToArray();
        }

        [HttpGet("{customerID}")]
        public Customer Get(int customerID) {

            return customers.FirstOrDefault(c => c.customerID == customerID);
        }
    }
}
