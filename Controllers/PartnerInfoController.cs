using a101_backend.Models.DataBase;
using a101_backend.Services.PartnerInfoService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerInfoController
    {
        IPartnerInfoService service;

        public PartnerInfoController(IPartnerInfoService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetPartnerInfoByUserID")]
        public async Task<PartnerInfo> GetPartnerInfoByUserID(int userID) {
            return await service.GetPartnerInfoByUserID(userID);
        }

    }
}
