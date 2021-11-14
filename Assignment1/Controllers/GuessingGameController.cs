using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class GuessingGameController : Controller
    {
        // GET
        public IActionResult Index()
        {
            if (HttpContext.Session.TryGetValue("randomNumber", out _)) return View();
            SetRandomNumber();
            return View();
        }

        private void SetRandomNumber()
        {
            var randomNumber = new Random().Next(1, 100);
            HttpContext.Session.SetInt32(key: "randomNumber", value: randomNumber);
        }

        [HttpPost]
        public IActionResult Index(int number)
        {
            var correct = number == HttpContext.Session.GetInt32("randomNumber");
            ViewBag.Message = correct ? "Correct" : "Wrong number";
            if(correct)
                SetRandomNumber();
            return View();
        }
    }
}