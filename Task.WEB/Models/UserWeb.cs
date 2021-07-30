using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.WEB.Models
{
    public class UserWeb
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<UsersOrder> Orders { get; set; }
    }
}
