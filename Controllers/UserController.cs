using a101_backend.Models.DataBase;
using a101_backend.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await service.GetUsers();
        }

        [HttpPost]
        public async Task<object> AddNewUser([FromBody] User user)
        {
            return await service.AddNewUser(user);
        }

        [HttpDelete]
        public async Task<User> DeleteUser(int userID)
        {
            return await service.DeleteUser(userID);
        }

        [HttpPatch]
        public async Task<object> UpdateUser([FromBody] User user)
        {
            return await service.UpdateUser(user);
        }
    }
}
