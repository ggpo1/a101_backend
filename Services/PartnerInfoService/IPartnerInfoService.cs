using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.PartnerInfoService
{
    public interface IPartnerInfoService
    {
        Task<PartnerInfo> GetPartnerInfoByUserID(int userID);
        Task<List<GetAllPartnersDTO>> GetPartners();
        Task<object> UpdatePartner();
        Task<object> AddNewPartner(PartnerInfo newPartner);
        Task<PartnerInfo> DeletePartner(int partnerInfoID);
    }
}
