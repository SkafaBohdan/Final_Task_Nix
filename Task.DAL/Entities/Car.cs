using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class Car
    {
        [Required]
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public Brand Brand { get; set; }
        public Specifications Specifications { get; set; }
    }
}
