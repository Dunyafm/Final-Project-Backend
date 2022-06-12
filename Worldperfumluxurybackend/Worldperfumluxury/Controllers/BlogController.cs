using Microsoft.AspNetCore.Mvc;

namespace Worldperfumluxury.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
