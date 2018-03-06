using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class Address
    {
       
        public int UserId { get; set; }
        public User User { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int AddressForeignKey { get; set; }
    }
}
