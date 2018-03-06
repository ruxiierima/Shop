using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class Address
    {
        public Address(int iD, string country, string city, string region, string street, string postalCode)
        {
            ID = iD;
            Country = country;
            City = city;
            Region = region;
            Street = street;
            PostalCode = postalCode;
        }

        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}
