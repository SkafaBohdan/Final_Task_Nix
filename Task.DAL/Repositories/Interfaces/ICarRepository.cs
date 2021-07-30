using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;

namespace Task.DAL.Repositories.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(CarEntity car);
        void UpdateCar(CarEntity car);

        List<CarEntity> GetAllViews();
        void DeleteCarById(int id);
    }
}
