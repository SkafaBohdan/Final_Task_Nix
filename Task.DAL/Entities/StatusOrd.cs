using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class StatusOrd
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
