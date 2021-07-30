using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class FirmDTO
    {
        public string FirmName { get; set; }

        public ICollection<CarDTO> Cars { get; set; }
    }
}
