using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL.DTO
{
    public class CarDTO
    {
        public string Model { get; set; }
        public string EngineName { get; set; }
        public float VEngine { get; set; }
        public float Price { get; set; }

        public string ImgPath { get; set; }

        public int FuelСonsumption { get; set; }


        public int FirmID { get; set; }

        public FirmDTO Firms { get; set; }

        public ICollection<OrdersDTO> Carts { get; set; }
    }
}
