using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.UserService
{
    public interface IUserService
    {
        Task<object> AddNewUser(User user);
        Task<List<User>> GetUsers();
        Task<User> DeleteUser(int userID);
        Task<object> UpdateUser(User user);
    }
}
