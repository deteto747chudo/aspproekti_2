using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsainBolt.Models;

namespace UsainBolt.Controllers
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
            var athlete = new Athlete
            {
                Name = "Usain Bolt",
                Sport = "Sprint",
                Bio = "Usain Bolt is a Jamaican retired sprinter, widely considered the greatest sprinter of all time. He holds world records in the 100 meters, 200 meters, and 4 × 100 meters relay.",
                Photos = new string[]
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKWt5zPsR-fRBHIOdh6OOlT5NVzvjbJqMg7g&s",
                    "https://img.olympics.com/images/image/private/t_s_pog_staticContent_hero_xl_2x/f_auto/primary/itgo4fceaazaicrrl7b2",
                    "https://ca-times.brightspotcdn.com/dims4/default/fee5c69/2147483647/strip/false/crop/2048x1313+0+0/resize/1486x953!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F35%2Ffb%2F641f6696055db8fdc468449456e4%2Fla-xpm-photo-2013-aug-12-la-sp-sn-usain-bolt-lightning-20130812",
                }
            };
            return View(athlete);
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
