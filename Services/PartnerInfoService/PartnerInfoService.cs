using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;

namespace a101_backend.Services.PartnerInfoService
{
    public class PartnerInfoService : IPartnerInfoService
    {
        public async Task<object> UpdatePartnerInfo(PartnerInfo partner)
        {
            try
            {
                var _updateTo = MyDb.db.PartnerInfo.FirstOrDefault(el => el.PartnerInfoID == partner.PartnerInfoID);
                _updateTo.FullName = partner.FullName;
                _updateTo.CompanyName = partner.CompanyName;
                _updateTo.CompanyState = partner.CompanyState;
                _updateTo.PhoneNumber = partner.PhoneNumber;
                _updateTo.CityID = partner.CityID;
                MyDb.db.Update(_updateTo);
                MyDb.db.SaveChanges();
                return await Task.Run(() => (object)new { status = true });
            }
            catch (Exception)
            {
                return await Task.Run(() => (object) new { status=false });
            }
        }
        public Task<object> AddNewPartner(PartnerInfo newPartner)
        {
            var added = MyDb.db.PartnerInfo.Add(newPartner);
            MyDb.db.SaveChanges();
            return Task.Run(() => (object) new { added.Entity.PartnerInfoID });
        }

        public async Task<PartnerInfo> DeletePartner(int partnerInfoID)
        {
            var el = MyDb.db.PartnerInfo.FirstOrDefault(elem => elem.PartnerInfoID == partnerInfoID);
            MyDb.db.PartnerInfo.Remove(el);
            MyDb.db.SaveChanges();
            return await Task.Run(() => el);
        }

        public Task<PartnerInfo> GetPartnerInfoByUserID(int userID)
        {
            return Task.Run(() => MyDb.db.PartnerInfo.FirstOrDefault(elem => elem.User.UserID == userID));
        }

        public Task<List<GetAllPartnersDTO>> GetPartners()
        {
            var Partners = MyDb.db.PartnerInfo.ToList();
            List<GetAllPartnersDTO> _partners = new List<GetAllPartnersDTO>();
            foreach (var elem in Partners)
            {
                var user = MyDb.db.User.FirstOrDefault(el => el.UserID == elem.UserID);
                var city = MyDb.db.City.FirstOrDefault(el => el.CityID == elem.CityID).CityName;
                _partners.Add
                (
                    new GetAllPartnersDTO()
                    {
                        user = user,
                        partnerInfo = elem,
                        city = city
                    }
                );
            }
            return Task.Run(() => _partners);
        }

    }
}
