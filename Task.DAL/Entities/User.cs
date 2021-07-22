using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entities
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(10)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Discount { get; set; }

        public Guid? RoleId { get; set; }

        public Role Role { get; set; }
    }
}
