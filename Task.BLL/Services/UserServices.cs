using System;
using Task.BLL.DTO;
using Task.BLL.Mappers;
using Task.BLL.Services.Interfaces;
using Task.DAL.Repositories.Interfaces;

namespace Task.BLL.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(UserDTO user)
        {
            _userRepository.AddUser(user.ToEntity());
        }

        public void DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUserId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
