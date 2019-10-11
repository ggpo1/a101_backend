using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public int? UserID { get; set; }
        [ForeignKey("CityID")]
        public virtual City City { get; set; }
        public int? CityID { get; set; }
    }
}
