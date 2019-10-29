using a101_backend.Models.DataBase;
using a101_backend.Services.CompanyStatusService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/company/status")]
    [ApiController]
    public class CompanyStatusController : ControllerBase
    {
        ICompanyStatusService service;

        public CompanyStatusController(ICompanyStatusService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<CompanyStatus>> Get()
        {
            return await service.GetStatuses();
        }
    }
}
