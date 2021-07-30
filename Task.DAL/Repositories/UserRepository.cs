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
    public class UserRepository : IUserRepository
    {
        private AvtoContext db;
        public UserRepository (AvtoContext context)
        {
            this.db = context;
        }
        public void AddUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
