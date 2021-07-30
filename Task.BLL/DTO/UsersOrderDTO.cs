using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class UsersOrderDTO
    {
        public string UserId { get; set; }


        public UserDTO Users { get; set; }
        public ICollection<OrdersDTO> UserOrder_Orders { get; set; }
    }
}
