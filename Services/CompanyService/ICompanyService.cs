using System.Threading.Tasks;
using System.Collections.Generic;

using a101_backend.Models.DataBase;

namespace a101_backend.Services.CompanyService
{
    public interface ICompanyService
    {
         Task<List<Company>> GetPartnerCompanies(int userID);
    }
}