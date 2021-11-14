using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class DoctorController : Controller
    {
        // GET
        public IActionResult FeverCheck()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult FeverCheck(float temperature)
        {
            if(temperature != 0)
               ViewBag.Message = DoctorModel.FeverCheck(temperature);
            return View();
        }
    }
}