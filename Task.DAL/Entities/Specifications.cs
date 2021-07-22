using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.DAL.Entities
{
    public class Specifications
    {
        [Required]
        public int Id { get; set; }
        public int CountDoor { get; set; }
        public int NumberSeats { get; set; }
        public TypeBody TypeBody { get; set; }
        public TypeEngine TypeEngine { get; set; }
    }
}
