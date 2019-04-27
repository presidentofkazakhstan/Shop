using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Registration
    {
        public Registration()
        {
            using (var context = new ShopContext())
            {
                Console.WriteLine("Введите логин: ");
                var login = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                var password = Console.ReadLine();


                int n = 1;
               
                foreach (var product in context.Products.ToList())
                {
                   
                    Console.WriteLine(n + "." +product.Name +" - "+ product.Price+"тг");
                    Console.WriteLine("--------------------------");
                    n++;
                  

                }

                Console.WriteLine($"Выберите продукт который хотите добавить в корзину(1-{n-1}):");
                int selectNumber = int.Parse(Console.ReadLine());
                
                if (selectNumber == 1)
                {
                  
                    var newUser = new User
                    {
                        Login = login,
                        Password = password,
                        //не получается дать значению продукту с таблицы Product
                  //     Product = 
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                


            }
        }
    }
}
