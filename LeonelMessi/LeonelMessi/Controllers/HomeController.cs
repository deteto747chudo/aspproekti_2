using LeonelMessi.Models;
using MessiSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeonelMessi.Controllers
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
            var messi = new Athlete
            {
                Name = "Lionel Messi",
                Sport = "Football (Soccer)",
                Biography = @"Lionel Messi is an Argentine professional footballer who plays for Inter Miami and the Argentina national team. 
                             He is widely considered one of the greatest players in football history, holding numerous records including multiple Ballon d'Or awards.",
                PhotoUrls = new List<string>
                {
                    "https://upload.wikimedia.org/wikipedia/commons/b/b8/Messi_vs_Nigeria_2018.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/8/89/Messi_inter_miami_2023.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/d/da/Lionel_Messi_WC2022_Trophy.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/3/34/Lionel_Messi_20180626.jpg"
                }
            };
            return View(messi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
