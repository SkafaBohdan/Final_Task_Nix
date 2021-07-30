using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Abstract;

namespace Task.DAL.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
