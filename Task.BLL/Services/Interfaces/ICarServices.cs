using System;
using System.Collections.Generic;
using Task.BLL.DTO;

namespace Task.BLL.Services.Interfaces
{
    public interface ICarServices
    {
        void AddFirm(CarDTO car);
        void UpdateFirm(CarDTO car);
        List<CarDTO> GetAllViews();
        void DeleteFirmById(int id);
    }
}
