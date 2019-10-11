using a101_backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.DTO
{
    public class DocumentInfoDTO
    {
        public Document Document { get; set; }
        public Company Company { get; set; }
        public PartnerInfo PartnerInfo { get; set; }
    }
}
