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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public Product GetProduct(int id)
        {
            return ShopContext.Products.Include(p => p.ProductName).SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts(int c)
        {
            return ShopContext.Products.ToList();
        }
        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
