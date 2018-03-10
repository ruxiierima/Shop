using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data.Repositories;
using Shop.Model;

namespace Shop.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        UserRepository Users { get; }
        ProductRepository Products { get; }
        OrderRepository Orders { get; }
        int Complete();
    }
}
