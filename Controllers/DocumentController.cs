using a101_backend.Models.DataBase;
using a101_backend.Models.Enums;
using a101_backend.Services.DocumentService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : Controller
    {

        public class DocStatus {
            public DocumentStatus status { get; set; }
        }

        IDocumentService service;

        public DocumentController(IDocumentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<Document>> GetDocs()
        {
            return await service.GetDocs();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Document> GetDoc(int id)
        {
            return await service.GetDocByID(id);
        }

        [HttpGet]
        [Route("getPartnerDocs")]
        public async Task<List<Document>> GetPartnerDocs(int partnerID)
        {
            return await service.GetPartnerDocs(partnerID);
        }

        [HttpGet]
        [Route("getCompanyDocs")]
        public async Task<List<Document>> GetCompanyDocs(int companyID)
        {
            return await service.GetCompanyDocuments(companyID);
        }

        [HttpPost]
        [Route("SaveDocInfo")]
        public async Task<Document> SaveDocInfo([FromBody] Document document)
        {
            return await service.SaveDocInfo(document);
        }

        [HttpPatch]
        [Route("docstatus/{id}")]
        public async Task<object> UpdateDocStatus(int id, [FromBody] DocStatus status)
        {
            return await service.UpdateDocumentStatus(id, status.status);
        }



        [HttpPost, DisableRequestSizeLimit]
        public async Task<object> AddNewDocument([FromForm]IFormFile file)
        {

            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = @"C:/a101_docs/";

            using (var stream = new FileStream(path + file.FileName, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return await Task.Run(() => Ok());
        }

        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> Download(string name)
        {
            if (name == null)
                return Content("filename not present");

            var path = @"C:/a101_docs/" + name;

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        [HttpDelete]
        [Route("{companyID}")]
        public async Task<object> RemoveDocumentInfo(int companyID)
        {
            return await service.RemoveDocumentInfo(companyID);
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {"", "text/plain"},
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},  
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}
