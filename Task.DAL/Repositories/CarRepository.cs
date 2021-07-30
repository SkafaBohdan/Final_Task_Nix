using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;
using Task.DAL.Repositories.Interfaces;

namespace Task.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private static List<CarEntity> _list = new List<CarEntity>();
        public void AddCar(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public void DeleteCarById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarEntity> GetAllViews()
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(CarEntity car)
        {
            throw new NotImplementedException();
        }
    }
}
