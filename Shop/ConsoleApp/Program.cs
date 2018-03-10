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
                Console.WriteLine("1-Seed the database, 2-Delete all users");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    DbSeed seed = new DbSeed();
                    seed.Seed();
                }else if (k == 2)
                {
                    var users = UnitOfWork.Users.GetAll();
                    UnitOfWork.Users.RemoveRange(users);
                    UnitOfWork.Complete();
                }
            }
        }
    }
}
