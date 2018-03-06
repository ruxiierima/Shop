using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data.IRepositories;
using Shop.Model;

namespace Shop.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public Order GetOrder(int id)
        {
            return ShopContext.Orders.Include(o => o.Products).SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<Order> GetOrders(int c)
        {
            throw new NotImplementedException();
            //TO DO : To implement this method
        }
        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
