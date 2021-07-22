using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class Brand
    {
        [Required]
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
