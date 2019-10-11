using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.CityService
{
    public interface ICityService
    {
        Task<List<City>> GetCities();
        Task<object> GetCityIDByName(string cityName);
        Task<City> GetCity(int cityID);
    }
}
