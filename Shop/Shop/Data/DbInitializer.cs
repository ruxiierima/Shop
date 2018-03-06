using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;

namespace Shop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
                return;
            //Adress adresa = new Adress("aaa", "bbb", "ccc", "ddd","dad");

            var users = new User[]
           {
                //new User("Dan", "DanChiorean","1234","chiorean@yahoo.com","078544541"),
           };
        }
    }
}
