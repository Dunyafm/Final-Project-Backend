using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
  
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
