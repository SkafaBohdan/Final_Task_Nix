using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.EF;
using Task.DAL.Entities;
using Task.DAL.Repositories.Interfaces;

namespace Task.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private AvtoContext db;

        public CarRepository(AvtoContext context)
        {
            this.db = context;
        }

        public void AddCar(CarEntity car)
        {
            if (car != null)
            {
                db.Add(car);
                db.SaveChanges();
            }
        }

        public void DeleteCarById(int id)
        {
            CarEntity toDelete = db.Find(id);
            if (toDelete != null)
            {
                db.Remove(toDelete);
                db.SaveChanges();
            }
        }

        public List<CarEntity> GetAllViews()
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(CarEntity car)
        {
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
