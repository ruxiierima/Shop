using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;
using Shop.Model;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var UnitOfWork = new UnitOfWork(new ShopContext()))
            {
                Console.WriteLine("--------------------------");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    User user = new User { Username = "Dandan", Fullname = "Dan Chiorean", Email = "chiorean@gmail.com", Password = "213fd", PhoneNumber = "12344321" };
                    UnitOfWork.Users.Add(user);
                    UnitOfWork.Complete();
                }
            }
        }
    }
}
