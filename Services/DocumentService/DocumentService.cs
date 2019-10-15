using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;
using a101_backend.Models.DTO;
using a101_backend.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace a101_backend.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        public async Task<List<Document>> GetCompanyDocuments(int companyID)
        {
            return await Task.Run(() => MyDb.db.Document.Where(elem => elem.CompanyID == companyID).ToList());
        }

        public async Task<Document> GetDocByID(int docID)
        {
            return await Task.Run(() => MyDb.db.Document.FirstOrDefault(elem => elem.DocumentID == docID));
        }

        public async Task<List<Document>> GetDocs()
        {
            return await Task.Run(() => MyDb.db.Document.ToList());
        }

        public async Task<List<Document>> GetPartnerDocs(int partnerID)
        {
            return await Task.Run(() => MyDb.db.Document.Where(elem => elem.PartnerInfoID == partnerID).ToList());
        }

        public async Task<object> RemoveDocumentInfo(int companyID)
        {
            var deleting = MyDb.db.Document.FirstOrDefault(elem => elem.CompanyID == companyID);
            if (deleting != null)
            {
                try
                {
                    MyDb.db.Document.Remove(deleting);
                    MyDb.db.SaveChanges();
                    return await Task.Run(() => (object)new { status = true });
                }
                catch (Exception)
                {
                    return await Task.Run(() => (object)new { status = false });
                }

            }
            else
            {
                return await Task.Run(() => (object)new { status = false });
            }
        }

        public async Task<Document> SaveDocInfo(Document document)
        {
            var savedDoc = MyDb.db.Document.Add(document);
            MyDb.db.SaveChanges();
            return await Task.Run(() => savedDoc.Entity);
        }

        public async Task<object> UpdateDocumentStatus(int documentInfoID, DocumentStatus newStatus)
        {
            try
            {
                var documentToUpdate = MyDb.db.Document.FirstOrDefault(el => el.DocumentID == documentInfoID);
                documentToUpdate.DocumentStatus = newStatus;
                MyDb.db.Update(documentToUpdate);
                MyDb.db.SaveChanges();
                return await Task.Run(() => (object) new { status=true });
            }
            catch (Exception)
            {
                return await Task.Run(() => (object) new { status=false });
            }
        }
    }
}
