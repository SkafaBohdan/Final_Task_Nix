using System;
using System.Collections.Generic;
using Task.BLL.DTO;
using Task.BLL.Services.Interfaces;
using Task.DAL.Repositories.Interfaces;

namespace Task.BLL.Services
{
    public class FirmServices : IFirmServices
    {
        private readonly IFirmRepository _firmRepository;
        public FirmServices(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }
        public void AddFirm(FirmDTO firm)
        {
            throw new NotImplementedException();
        }

        public void DeleteFirmById(int id)
        {
            throw new NotImplementedException();
        }

        public List<FirmDTO> GetAllViews()
        {
            throw new NotImplementedException();
        }

        public void UpdateFirm(FirmDTO firm)
        {
            throw new NotImplementedException();
        }
    }
}
