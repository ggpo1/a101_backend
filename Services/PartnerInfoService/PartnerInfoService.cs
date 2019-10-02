using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;

namespace a101_backend.Services.PartnerInfoService
{
    public class PartnerInfoService : IPartnerInfoService
    {
        public Task<PartnerInfo> GetPartnerInfoByUserID(int userID)
        {
            return Task.Run(() => MyDb.db.PartnerInfo.FirstOrDefault(elem => elem.User.UserID == userID));
        }
    }
}
