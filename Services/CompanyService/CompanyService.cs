using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using a101_backend.Models.DataBase;
using a101_backend.Models;
using a101_backend.Models.DTO;
using System;

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

        public async Task<object> RemoveCompany(int companyID)
        {
            var deleting = MyDb.db.Company.FirstOrDefault(el => el.CompanyID == companyID);
            if (deleting != null)
            {
                try
                {
                    MyDb.db.Company.Remove(deleting);
                    MyDb.db.SaveChanges();
                    return await Task.Run(() => (object)new { status = true });
                }
                catch (Exception)
                {
                    return await Task.Run(() => (object)new { status = false });
                }
            }
            else
            {
                return await Task.Run(() => (object)new { status = false });
            }
        }

        public async Task<object> UpdateCompany(Company company)
        {
            try
            {
                var updated = MyDb.db.Company.FirstOrDefault(elem => elem.CompanyID == company.CompanyID);
                updated.CompanyName = company.CompanyName;
                updated.ContactPersonFullName = company.ContactPersonFullName;
                updated.ContactPersonPhoneNumber = company.ContactPersonPhoneNumber;
                updated.ContactPersonCompanyState = company.ContactPersonCompanyState;
                updated.Status = company.Status;
                updated.PartnerInfoID = company.PartnerInfoID;
                updated.CityID = company.CityID;
                MyDb.db.Update(updated);
                MyDb.db.SaveChanges();
                if (updated != null && updated == company) 
                    return await Task.Run(() => (object) new { status = true });
                else
                    return await Task.Run(() => (object) new { status = false });
            }
            catch (Exception)
            {
                return await Task.Run(() => (object) new { status = false });
            }
        }
    }
}