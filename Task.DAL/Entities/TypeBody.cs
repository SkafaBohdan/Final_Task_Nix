using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class TypeBody
    {
        [Required]
        public int Id { get; set; }
        public string BodyName { get; set; }
    }
}
