namespace Shop
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopContext : DbContext
    {

        public ShopContext()
            : base("name=ShopContext")
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

    }


}