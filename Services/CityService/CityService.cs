using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;

namespace a101_backend.Services.CityService
{
    public class CityService : ICityService
    {
        public async Task<List<City>> GetCities()
        {
            return await Task.Run(() => MyDb.db.City.ToList());
        }

        public async Task<City> GetCity(int cityID)
        {
            return await Task.Run(() => MyDb.db.City.FirstOrDefault());
        }

        public async Task<object> GetCityIDByName(string cityName)
        {
            return await Task.Run(() => (object) new { cityID = MyDb.db.City.FirstOrDefault(elem => elem.CityName == cityName).CityID });
        }
    }
}
