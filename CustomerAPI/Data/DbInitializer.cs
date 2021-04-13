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
            var customer1 = new Customer { name = "company1", address = "Fakestreet1"};
            var customer2 = new Customer { name = "company2", address = "Fakestreet2"};

            context.Add(customer1);
            context.Add(customer2);

            context.SaveChanges();
        }
    }
}
