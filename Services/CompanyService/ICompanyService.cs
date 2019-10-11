using System.Threading.Tasks;
using System.Collections.Generic;

using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;

namespace a101_backend.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<List<Company>> GetPartnerCompanies(int userID);
        Task<List<CompaniesListingDTO>> GetCompanies();
        Task<object> AddNewCompany(Company company);
    }
}