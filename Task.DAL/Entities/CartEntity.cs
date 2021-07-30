using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Abstract;

namespace Task.DAL.Entities
{
    public class CartEntity : BaseEntity
    {

        public int CarID { get; set; }
        public int UsersOrderID { get; set; }


        public int StatusCartID { get; set; }
    }
}
