using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using a101_backend.Services.CompanyService;
using a101_backend.Models.DataBase;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController
    {
        ICompanyService service;

        public CompanyController(ICompanyService service) 
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetPartnerCompanies")]
        public async Task<List<Company>> GetPartnerCompanies(int userID)
        {
            return await service.GetPartnerCompanies(userID);
        }
    }
}