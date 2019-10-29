using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace a101_backend.AmoMiddleWare.Controllers
{
    [Route("api/amo/auth")]
    [ApiController]
    public class AuthController
    {
        private static readonly HttpClient client = new HttpClient();

        public readonly Dictionary<string, string> AmoData = new Dictionary<string, string>()
        {
            { "url", "https://technovik.amocrm.ru/" },
            { "login", "v.arkhangelsky@technovik.ru" },
            { "hash", "62224bdf2a291f97c61524e5a91df09f56eba10d" }
        };

        

        [HttpPost]
        public async Task<object> GetAuth()
        {
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
            // конвертим тело ответа в строку и возвращаем
            string _response = await response.Content.ReadAsStringAsync();
            // десериализация json в c# object
            var jsonObj = JsonConvert.DeserializeObject(_response);
            // возвращаем результат из amocrm
            return await Task.Run(() => jsonObj);
        }
    }
}
