using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class DrinksController : Controller
    {
        private IDrinkRepository repository;

       /* public DrinksController(IDrinkRepository repo)
        {
            repository = repo;
        }
       */
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Queue()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Order(string cName, string dName)
        {
            /*if (!repository.Drinks.Any())
            {
                //repository.Drinks.Add(Drink);
            }
            */

            return View();
        }
    }
}
