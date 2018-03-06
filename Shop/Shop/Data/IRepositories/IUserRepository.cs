using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;

namespace Shop.Data.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetUsers(int c);
        User GetUser(int id);
    }
}
