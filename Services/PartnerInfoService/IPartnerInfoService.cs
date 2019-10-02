using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.PartnerInfoService
{
    public interface IPartnerInfoService
    {
        Task<PartnerInfo> GetPartnerInfoByUserID(int userID);
    }
}
