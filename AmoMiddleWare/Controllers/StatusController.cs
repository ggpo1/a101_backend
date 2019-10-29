using a101_backend.AmoMiddleWare.Models;
using a101_backend.Models;
using a101_backend.Models.DataBase;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace a101_backend.AmoMiddleWare.Controllers
{
    [Route("api/amo/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        public readonly Dictionary<string, string> AmoData = new Dictionary<string, string>()
        {
            { "url", "https://technovik.amocrm.ru/" },
            { "login", "v.arkhangelsky@technovik.ru" },
            { "hash", "62224bdf2a291f97c61524e5a91df09f56eba10d" }
        };

        [HttpPatch]
        public async Task<object> UpdateStatuses()
        {
            List<CompanyStatus> dbStatuses = MyDb.db.CompanyStatuse.ToList();

            // формирование контента для запроса из данных для входа
            Dictionary<string, string> contentData = new Dictionary<string, string>()
            {
                { "USER_LOGIN", this.AmoData["login"] },
                { "USER_HASH", this.AmoData["hash"] }
            };
            // инициализирует контент со значениями
            FormUrlEncodedContent content = new FormUrlEncodedContent(contentData);
            // делаем запрос и сохраняем в переменную response
            HttpResponseMessage response = await client.PostAsync(this.AmoData["url"] + "private/api/auth.php?type=json", content);

            response = await client.GetAsync(Info.AmoData["url"] + "api/v2/pipelines?id=32226");
            string _response = await response.Content.ReadAsStringAsync();
            dynamic jsonObj = JsonConvert.DeserializeObject(_response);
            dynamic funnel = jsonObj["_embedded"]["items"]["32226"]["statuses"];
            List<CompanyStatus> newStatuses = new List<CompanyStatus>();
            foreach (var el in funnel)
            {
                foreach (var elem in el)
                {
                    newStatuses.Add(new CompanyStatus()
                        {
                            CompanyStatusName = elem["name"],
                            CompanyStatusColor = elem["color"]
                        }
                    );
                }
            }
            bool check = false;
            foreach (var newElem in newStatuses)
            {
                var exist = dbStatuses.FirstOrDefault(elem => elem.CompanyStatusName == newElem.CompanyStatusName);
                if (exist == null)
                {
                    MyDb.db.CompanyStatuse.Add(newElem);
                    check = true;
                }
            }
            MyDb.db.SaveChanges();

            return await Task.Run(() => new { updated = check });
        }
    }
}
