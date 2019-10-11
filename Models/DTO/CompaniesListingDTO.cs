using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.DTO
{
    public class CompaniesListingDTO
    {
        public Company Company { get; set; }
        public PartnerInfo PartnerInfo { get; set; }
        public City City { get; set; }
    }
}
