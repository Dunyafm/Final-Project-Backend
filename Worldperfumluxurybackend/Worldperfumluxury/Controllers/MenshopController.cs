﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Controllers
{
    public class MenshopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
