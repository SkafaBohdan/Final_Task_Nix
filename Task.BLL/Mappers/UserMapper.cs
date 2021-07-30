using Task.BLL.DTO;
using Task.DAL.Entities;

namespace Task.BLL.Mappers
{
    public static class UserMapper
    {
        public static UserEntity ToEntity(this UserDTO user)
        {
            return new UserEntity
            {
                Age = user.Age,
                Login = user.Login,
                Name = user.Name
            };
        }
    }
}
