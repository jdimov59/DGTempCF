using DGTempCF.Data;
using System.Web.Mvc;

namespace DGTempCF.Web.Controllers
{
    public class FileController : Controller
    {
        private DGTempCFContext db = new DGTempCFContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}