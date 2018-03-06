using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;

namespace Shop.Data.IRepositories
{
    public interface IOrderRepository: IRepository<Order>
    {
        IEnumerable<Order> GetOrders(int c);
        Order GetOrder(int id);
    }
}
