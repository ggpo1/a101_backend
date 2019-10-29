using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;
using a101_backend.Services.PartnerInfoService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        readonly ILogger<PartnerInfoController> log;

        public PartnerInfoController(IPartnerInfoService service, ILogger<PartnerInfoController> log)
        {
            this.service = service;
            this.log = log;
        }

        [HttpGet]
        [Route("GetPartnerInfoByUserID")]
        public async Task<PartnerInfo> GetPartnerInfoByUserID(int userID) {
            return await service.GetPartnerInfoByUserID(userID);
        }

        [HttpGet]
        [Route("GetPartners")]
        public async Task<List<GetAllPartnersDTO>> GetPartners()
        {
            log.LogInformation("GET Partners");
            return await service.GetPartners();
        }

        [HttpPost]
        public async Task<object> AddNewPartner([FromBody] PartnerInfo newPartner)
        {
            return await service.AddNewPartner(newPartner);
        }

        [HttpDelete]
        public async Task<PartnerInfo> DeletePartner(int partnerInfoID)
        {
            return await service.DeletePartner(partnerInfoID);
        }

        [HttpPatch]
        public async Task<object> UpdatePartnerInfo([FromBody] PartnerInfo partnerInfo)
        {
            return await service.UpdatePartnerInfo(partnerInfo);
        }
    }
}
