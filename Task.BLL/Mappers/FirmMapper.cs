using Task.BLL.DTO;
using Task.DAL.Entities;

namespace Task.BLL.Mappers
{
    public static class FirmMapper
    {
        public static FirmEntity ToEntity(this FirmDTO firm)
        {
            return new FirmEntity
            {
                FirmName = firm.FirmName
            };
        }
    }
}
