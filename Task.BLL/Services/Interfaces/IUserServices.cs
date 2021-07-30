using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.BLL.DTO;

namespace Task.BLL.Services.Interfaces
{
    public interface IUserServices
    {
        void AddUser(UserDTO user);
        void UpdateUser(UserDTO user);
        UserDTO GetUserId(int id);
        void DeleteUserById(int id);
    }
}
