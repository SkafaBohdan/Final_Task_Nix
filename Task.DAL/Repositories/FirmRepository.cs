using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;
using Task.DAL.Repositories.Interfaces;

namespace Task.DAL.Repositories
{
    public class FirmRepository : IFirmRepository
    {
        private static List<FirmEntity> _list = new List<FirmEntity>();
        public void AddFirm(FirmEntity firm)
        {
            throw new NotImplementedException();
        }

        public void DeleteFirmById(int id)
        {
            throw new NotImplementedException();
        }

        public List<FirmEntity> GetAllViews()
        {
            throw new NotImplementedException();
        }

        public void UpdateFirm(FirmEntity firm)
        {
            throw new NotImplementedException();
        }
    }
}
