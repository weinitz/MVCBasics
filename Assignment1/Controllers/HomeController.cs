﻿using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    }
}