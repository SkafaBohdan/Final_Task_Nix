using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;

namespace Task.DAL.Repositories.Interfaces
{
    public interface IFirmRepository
    {
        void AddFirm(FirmEntity firm);
        void UpdateFirm(FirmEntity firm);
        List<FirmEntity> GetAllViews();
        void DeleteFirmById(int id);
    }
}

