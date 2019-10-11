using a101_backend.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.DataBase
{
    public class Document
    {
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        [ForeignKey("PartnerInfoID")]
        public int PartnerInfoID { get; set; }
        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
    }
}
