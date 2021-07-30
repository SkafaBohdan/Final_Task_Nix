using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class UserDTO
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }    
        public ICollection<UsersOrderDTO> Orders { get; set; }
    }
}
