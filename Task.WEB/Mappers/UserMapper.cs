using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.BLL.DTO;
using Task.WEB.Models;

namespace Task.WEB.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToDomain(this UserWeb user)
        {
            if (user == null)
                return null;

            return new UserDTO
            {
                Name = user.Name,
                Login = user.Login,
                Age = user.Age,

                Orders = user.Orders.Select(x => x.ToDomain()).ToList()
            };
        }
    }
}
