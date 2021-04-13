using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI {
    public class Customer {
        public int customerId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Customer() {
        }
    }
}
