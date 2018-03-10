using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.Data;

namespace Shop.Data.IRepositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetAddresses(int a);
        Address GetAddress(int id);
    }
}
