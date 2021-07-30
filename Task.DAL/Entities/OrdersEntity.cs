using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Abstract;

namespace Task.DAL.Entities
{
    public class OrdersEntity
    {
        public int CarID { get; set; }
        public int UsersOrderID { get; set; }

        public int StatusOrderID { get; set; }

        public int CountBuy_item { get; set; }
        public double Price { get; set; }
    }
}
