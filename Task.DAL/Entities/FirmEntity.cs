using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Abstract;

namespace Task.DAL.Entities
{
    public class FirmEntity : BaseEntity
    {
        public string FirmName { get; set; }
    }
}
