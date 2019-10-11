using a101_backend.Models.Enums;

namespace a101_backend.Models.DataBase
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ContactPersonFullName { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string ContactPersonCompanyState { get; set; }
        public CompanyStatus Status { get; set; }
        public int CityID { get; set; }
        public virtual City City { get; set; }
        public int PartnerInfoID { get; set; }
        public virtual PartnerInfo PartnerInfo { get; set; }
    }
}