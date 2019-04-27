using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class User
    {

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Login { get; set; }

        public string Password { get; set; }


        public virtual Product Product { get; set; }
    }
}
