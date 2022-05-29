using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Controllers
{
    public class Shopping_cartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
