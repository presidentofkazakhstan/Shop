using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class LogInAccount
    {
        public LogInAccount()
        {
            using (var context = new ShopContext())
            {
                Console.WriteLine("Введите логин: ");
                var login = Console.ReadLine();

                foreach (var user in context.Users)
                {
                    if(login == user.Login)
                    {
                        Console.WriteLine("Ваша корзина: ");
                        Console.WriteLine("Название: "+  user.Product.Name +"\nЦена: "+ user.Product.Price);
                    }
                    else
                    {
                        Exception exception = new Exception(); 
                    }
                }

            }
        }
    }
}
