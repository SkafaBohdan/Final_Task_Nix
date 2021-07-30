using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BLL.DTO;
using Task.DAL.Entities;

namespace Task.BLL.Mappers
{
    public static class CarMapper
    {
        public static CarEntity ToEntity(this CarDTO car)
        {
            return new CarEntity
            {
                EngineName = car.EngineName,
                Model = car.Model,
                Price = car.Price,
                VEngine = car.VEngine,
                ImgPath = car.ImgPath,
                FuelСonsumption = car.FuelСonsumption
            };
        }
    }
}
