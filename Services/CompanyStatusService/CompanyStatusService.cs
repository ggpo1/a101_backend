using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;

namespace a101_backend.Services.CompanyStatusService
{
    public class CompanyStatusService : ICompanyStatusService
    {
        public async Task<List<CompanyStatus>> GetStatuses()
        {
            return await Task.Run(() => MyDb.db.CompanyStatuse.ToList());
        }
    }
}
