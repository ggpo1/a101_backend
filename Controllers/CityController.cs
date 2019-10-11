using a101_backend.Models.DataBase;
using a101_backend.Services.CityService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController
    {
        public ICityService service;

        public CityController(ICityService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<City>> GetCities()
        {
            return await service.GetCities();
        }

        [HttpGet("{id}")]
        public async Task<City> GetCity(int id)
        {
            return await service.GetCity(id);
        }

        [HttpGet]
        [Route("GetCityIDByName")]
        public async Task<object> GetCityIDByName(string cityName)
        {
            return await service.GetCityIDByName(cityName);
        }
    }
}
