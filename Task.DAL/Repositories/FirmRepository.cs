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
    public class FirmRepository : IFirmRepository
    {
        private AvtoContext db;

        public FirmRepository(AvtoContext context)
        {
            this.db = context;
        }

        public void AddFirm(FirmEntity firm)
        {
            if (firm != null)
            {
                db.Add(firm);
                db.SaveChanges();
            }
        }

        public void DeleteFirmById(int id)
        {
            FirmEntity toDelete = db.Find(id);
            if (toDelete != null)
            {
                db.Remove(toDelete);
                db.SaveChanges();
            }
        }

        public List<FirmEntity> GetAllViews()
        {
            throw new NotImplementedException();
        }

        public void UpdateFirm(FirmEntity firm)
        {
            db.Entry(firm).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
