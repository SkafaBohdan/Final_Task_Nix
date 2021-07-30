using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class StatusCartDTO
    {
        public string StatusName { get; set; }


        public ICollection<CartDTO> Carts { get; set; }
    }
}
