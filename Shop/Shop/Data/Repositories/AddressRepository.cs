using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }

        public Address GetAddress(int id)
        {
            return ShopContext.Addresses.Include(u => u.Country).SingleOrDefault(u => u.UserId == id);
        }

        public IEnumerable<Address> GetAddresses(int a)
        {
            return ShopContext.Addresses.ToList();
        }
        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
