using System;
using System.Collections.Generic;

namespace Shop
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } 

        public int Price { get; set; }


        public virtual ICollection<User> User  { get; set; }
    }

}