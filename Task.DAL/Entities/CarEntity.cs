using System;
using Task.DAL.Abstract;

namespace Task.DAL.Entities
{
    public class CarEntity : BaseEntity 
    {
        public string Model { get; set; }
        public string EngineName { get; set; }
        public float VEngine { get; set; }
        public float Price { get; set; }

        public string ImgPath { get; set; }

        public int FuelСonsumption { get; set; }


        public int FirmID { get; set; }
    }
}
