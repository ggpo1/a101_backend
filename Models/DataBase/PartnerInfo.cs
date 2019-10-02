using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.DataBase
{
    public class PartnerInfo
    {
        public int PartnerInfoID { get; set; }
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string CompanyState { get; set; }
        public string PhoneNumber { get; set; }
        public virtual User User { get; set; }
        public virtual City City { get; set; }
    }
}
