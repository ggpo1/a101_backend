using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using a101_backend.Models.DataBase;
using a101_backend.Models;

namespace a101_backend.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        public async Task<List<Company>> GetPartnerCompanies(int userID)
        {
            List<Company> comp = MyDb.db.Companies.Where(elem => elem.UserID == userID).ToList();
            return await Task.Run(() => comp);
        }
    }
}