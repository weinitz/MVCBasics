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
            var randomNumber = HttpContext.Session.GetInt32("randomNumber");
            var correct = number == randomNumber;
            if (correct)
            {
                SetRandomNumber();
                ViewBag.Message = "Correct";
            }
            else
            {
                ViewBag.Message = number < randomNumber ? "Your guess is to low." : "your guess is to high";
            }
            return View();
        }
    }
}