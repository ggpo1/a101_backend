using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.DTO
{
    public class GetAllPartnersDTO
    {
        public User user { get; set; }
        public PartnerInfo partnerInfo { get; set; }
        public string city { get; set; }
    }
}
