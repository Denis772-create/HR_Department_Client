﻿using Microsoft.AspNetCore.Mvc;

namespace HR.Department.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
