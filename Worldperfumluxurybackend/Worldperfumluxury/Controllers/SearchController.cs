using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Worldperfumluxury.Models;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

namespace Worldperfumluxury.Controllers
{
    public class SearchController : Controller
    {
        FileClass fc = new FileClass();
        [System.Web.Mvc.HttpPost]
        public async Task<IActionResult> Index(IFormFile fifile)
        {
            string ext = Path.GetExtension(fifile.FileName);

            var fisave = Path.Combine(_iweb.WebRootPath, "Uploads", fifile.FileName);
            var stream = new FileStream(fisave, FileMode.Create);
            await fifile.CopyToAsync(stream);
            stream.Close();

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {

            var displayfc = Path.Combine(iweb.WebRootPath, "Uploads");
            DirectoryInfo di = new DirectoryInfo(displayfc);
            List<FileInfo> fileinfo = di.GetFiles().ToList(); ;
            //FileClass.Filename = fileinfo;
            return View();
        }



        public IActionResult Delete(string filedel)
        {
            filedel = Path.Combine(_iweb.WebRootPath, "Uploads", filedel);
            FileInfo fi = new FileInfo(filedel);
            if (fi != null)
            {
                System.IO.File.Delete(filedel);
                fi.Delete();
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename is not avaiable");
            var path = Path.Combine(_iweb.WebRootPath, "Uploads", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
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
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }



    }
    
}
