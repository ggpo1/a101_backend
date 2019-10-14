using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Services.DocumentService
{
    public interface IDocumentService
    {
        Task<List<Document>> GetCompanyDocuments(int companyID);
        Task<List<Document>> GetPartnerDocs(int partnerID);
        Task<List<Document>> GetDocs();
        Task<Document> GetDocByID(int docID);
        Task<Document> SaveDocInfo(Document document); 
        Task<object> RemoveDocumentInfo(int companyID);
    }
}
