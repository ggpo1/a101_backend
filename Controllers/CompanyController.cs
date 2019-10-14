using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using a101_backend.Services.CompanyService;
using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;

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
        public async Task<List<CompaniesListingDTO>> GetCompanies()
        {
            return await service.GetCompanies();
        }

        [HttpPost]
        public async Task<object> AddNewCompany([FromBody] Company company)
        {
            return await service.AddNewCompany(company);
        }

        [HttpDelete]
        [Route("{companyID}")]
        public async Task<object> RemoveCompany(int companyID)
        {
            return await service.RemoveCompany(companyID);
        }

        [HttpPatch]
        public async Task<object> UpdateCompany([FromBody] Company company)
        {
            return await service.UpdateCompany(company);
        }

        [HttpGet]
        [Route("GetPartnerCompanies")]
        public async Task<List<Company>> GetPartnerCompanies(int userID)
        {
            return await service.GetPartnerCompanies(userID);
        }
    }
}