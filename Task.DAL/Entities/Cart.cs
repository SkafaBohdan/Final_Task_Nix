using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class Cart
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CarId { get; set; }
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

    }
}
