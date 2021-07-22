using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.DAL.Entities
{
    public class TypeEngine
    {
        [Required]
        public int Id { get; set; }
        public string EngineName { get; set; }

    }
}
