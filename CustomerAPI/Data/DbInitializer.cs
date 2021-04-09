using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Data {
    public class DbInitializer {
        public static void Initialize(CustomerContext context) {
            context.Database.EnsureCreated();

            if (context.Customers.Any()) {
                return;   // DB has been seeded
            }
            var customer1 = new Customer { name = "aaa",surname ="xxx"};
            var customer2 = new Customer { name = "bbb", surname ="yyy" };

            context.Add(customer1);
            context.Add(customer2);

            context.SaveChanges();
        }
    }
}
