using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.Data.IRepositories;
using Shop.Data.Repositories;

namespace Shop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        
        public UnitOfWork(ShopContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Products = new ProductRepository(_context);
            Orders = new OrderRepository(_context);
            Addresses = new AddressRepository(_context);

        }
        public IUserRepository Users { get; set; }
        public IProductRepository Products { get; set; }
        public IOrderRepository Orders { get; set; }
        public IAddressRepository Addresses { get; set; }

        UserRepository IUnitOfWork.Users => throw new NotImplementedException();

        ProductRepository IUnitOfWork.Products => throw new NotImplementedException();

        OrderRepository IUnitOfWork.Orders => throw new NotImplementedException();




        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
