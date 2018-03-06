using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data.IRepositories;
using Shop.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ShopContext context) : base(context)
        {

        }
        public User GetUser(int id)
        {
            return ShopContext.Users.Include(u => u.Username).SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers(int c)
        {
            return ShopContext.Users.ToList();
        }
        public ShopContext ShopContext
        {
            get { return Context as ShopContext; }
        }
    }
}
