using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.DAL.Entities
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }
        public User User { get; set; }
        public StatusOrd Status { get; set; }
    }
}
