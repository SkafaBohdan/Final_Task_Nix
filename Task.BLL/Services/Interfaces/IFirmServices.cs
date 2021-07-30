using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BLL.DTO;

namespace Task.BLL.Services.Interfaces
{
    public interface IFirmServices
    {
        void AddFirm(FirmDTO firm);
        void UpdateFirm(FirmDTO firm);
        List<FirmDTO> GetAllViews();
        void DeleteFirmById(int id);
    }
}
