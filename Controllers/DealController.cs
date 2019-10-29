using a101_backend.Services.DealService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealController : ControllerBase
    {
        IDealService service;

        public DealController(IDealService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Deal()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public void SetStatus(string leads)
        {
            service.SetStatus(leads);
        }

    }
}
