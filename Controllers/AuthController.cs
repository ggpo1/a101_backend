using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;
using a101_backend.Services.AuthService;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController
    {
        IAuthService service;

        public AuthController(IAuthService service)
        {
            this.service = service;
        }
        
        [HttpPost]
        public async Task<object> Post([FromBody] AuthUserDTO user)
        {
            return await service.GetAuth(user);
        }
    }
}