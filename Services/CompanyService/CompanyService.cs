using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using a101_backend.Models.DataBase;
using a101_backend.Models;
using a101_backend.Models.DTO;

namespace a101_backend.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        public async Task<object> AddNewCompany(Company company)
        {
            var added = MyDb.db.Company.Add(company);
            MyDb.db.SaveChanges();
            return await Task.Run(() => (object) new { added.Entity.CompanyID });
        }

        public async Task<List<CompaniesListingDTO>> GetCompanies()
        {
            List<Company> companies = MyDb.db.Company.ToList();
            List<CompaniesListingDTO> companiesListtingDTO = new List<CompaniesListingDTO>();
            foreach (var comp in companies)
            {
                companiesListtingDTO.Add(
                    new CompaniesListingDTO()
                    {
                        Company = comp,
                        PartnerInfo = MyDb.db.PartnerInfo.FirstOrDefault(el => el.PartnerInfoID == comp.PartnerInfoID),
                        City = MyDb.db.City.FirstOrDefault(el => el.CityID == comp.CityID)
                    }
                );
            }
            return await Task.Run(() => companiesListtingDTO);
        }

        public async Task<List<Company>> GetPartnerCompanies(int userID)
        {
            List<Company> comp = MyDb.db.Company.Where(elem => elem.PartnerInfo.PartnerInfoID == userID).ToList();
            return await Task.Run(() => comp);
        }
    }
}