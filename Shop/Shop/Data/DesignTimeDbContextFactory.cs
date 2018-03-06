using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ShopContext>
    {
        public ShopContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ShopContext>();

            builder.UseSqlServer(Configuration.ConnectionString);
            return new ShopContext(builder.Options);
        }
    }
}
