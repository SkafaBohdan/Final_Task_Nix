using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entities;

namespace Task.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(UserEntity user);
        void UpdateUser(UserEntity user); 
        UserEntity GetUserId(int id);
        void DeleteUserById(int id);
    }
}
