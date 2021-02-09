using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurants.Models;

namespace TopRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                string? dish = r.FavoriteDish ?? "It's all tasty!";
                restaurantList.Add($"#{r.Rank} {r.Name} \t\tFavorite Dish: {dish} \t\tAddress: {r.Address} \t\tPhone Number: {r.PhoneNumber} \t\tWebsite: {r.Website}");
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult SuggestRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestRestaurant(Suggestion newSuggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.SuggestRestaurant(newSuggestion);
                return View("Confirmation", newSuggestion);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SuggestedRestaurants()
        {
            return View(TempStorage.Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
