using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class OrdersDTO
    {
        public int CarID { get; set; }
        public int UsersOrderID { get; set; }

        public int StatusOrderID { get; set; }

        
        public int CountBuy_item { get; set; }
        public double Price { get; set; }


        public CarDTO Cars { get; set; }
        public UsersOrderDTO UsersOrders { get; set; }
        public StatusOrderDTO StatusOrder { get; set; }
        public ICollection<CartDTO> Carts { get; set; }

    }
}
