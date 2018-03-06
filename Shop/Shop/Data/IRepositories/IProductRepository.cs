using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using Shop.Model;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProducts(int c);
        Product GetProduct(int id);
    }
}
