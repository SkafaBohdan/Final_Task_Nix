using System;
using System.Collections.Generic;
using Task.BLL.DTO;

namespace Task.BLL.Services.Interfaces
{
    public interface ICarServices
    {
        void AddCar(CarDTO car);
        void UpdateCar(CarDTO car);
        List<CarDTO> GetAllViews();
        void DeleteCarById(int id);
    }
}
