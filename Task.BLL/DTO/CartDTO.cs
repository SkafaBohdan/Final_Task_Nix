using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class CartDTO
    {
      
        public int ItemID { get; set; }
        public int UsersOrderID { get; set; }


        public int StatusCartID { get; set; }


        public StatusCartDTO StatusCarts { get; set; }
        public OrdersDTO Orders { get; set; }

    }
}
