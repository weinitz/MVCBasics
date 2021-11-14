using System.Collections.Generic;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }        
        public IActionResult Projects()
        {
            //var viewModel = new ProjectViewModel();
            var viewModel = new List<ProjectViewModel>
            {
                new ProjectViewModel()
                {
                    Description = "Hänga gubbe",
                    Title = "LexiconHangman",
                    Url = "https://github.com/weinitz/LexiconHangman"
                },
                new ProjectViewModel()
                {
                    Description = "Kalkulator",
                    Title = "LexiconCalculator",
                    Url = "https://github.com/weinitz/LexiconCalculator"
                },
                new ProjectViewModel()
                {
                    Description = "Grupparbete",
                    Title = "LexiconTodoIt",
                    Url = "https://github.com/weinitz/LexiconTodoIt"
                },
                new ProjectViewModel()
                {
                    Description = "Tre i rad",
                    Title = "TicTacToe",
                    Url = "https://github.com/weinitz/TicTacToe"
                },
                new ProjectViewModel()
                {
                    Description = "Vending Machine",
                    Title = "Vending Machine",
                    Url = "https://github.com/weinitz/Vending-Machine"
                },
                new ProjectViewModel()
                {
                    Description = "Grundläggande html och css",
                    Title = "Basic-HTML-Fundamentals",
                    Url = "https://github.com/weinitz/Basic-HTML-Fundamentals"
                }
            };

            return View(viewModel);
        }
    
    }
}