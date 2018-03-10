using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.Data;

namespace ConsoleApp
{
    public class DbSeed
    {
        void Seed()
        {
            using (var UnitOfWork = new UnitOfWork(new ShopContext()))
            {
                var addresses = new Address[]
         {
                new Address{ Country="Romania",Region="Cluj",City="Cluj-Napoca",PostalCode="3123",Street="B-dul Titulescu nr.145, Bl.3, Ap. 150"},
                new Address{ Country="Romania",Region="Satu-Mare",City="Satu-Mare",PostalCode="2003",Street="Strada Aurel Scuiu 32, Ap. 2"},
                new Address{ Country="Romania",Region="Cluj",City="Turda",PostalCode="3113",Street="B-dul Titulescu nr.145, Bl.3, Ap. 150"},
                new Address{ Country="Danemarca",Region="Iutland",City="Aarhus",PostalCode="32231",Street="Ny Munkegade 2-20"}
         };

                var users = new User[]
                {
                new User { Username="Dan12", Fullname="Dan Chiorean", Email="chiorean@mail.com",Password="1234",PhoneNumber="0123456789", Address=addresses[0]  },
                new User { Username="Alex12", Fullname="Alex Matei", Email="alex@mail.com",Password="1234",PhoneNumber="9876543210", Address=addresses[1]  },
                new User { Username="Geroge12334", Fullname="George Dan", Email="geroge@mail.com",Password="1234",PhoneNumber="0123456789", Address=addresses[2]  },
                new User { Username="Festila007", Fullname="Celement Festila", Email="festila@mail.com",Password="1234",PhoneNumber="012394923", Address=addresses[3]  }
                };

                foreach(Address address in addresses)
                {
                    //TODO: To make a repository for Address
                   // UnitOfWork.
                }

                foreach(User user in users)
                {
                    UnitOfWork.Users.Add(user);

                }
                UnitOfWork.Complete();
            }
        }
    }
}
