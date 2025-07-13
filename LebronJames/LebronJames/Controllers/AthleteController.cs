using System.Collections.Generic;
using LebronJames.Models;
using Microsoft.AspNetCore.Mvc;
using LebronJames.Models;

namespace LebronJames.Controllers
{
    public class AthleteController : Controller
    {
        public ActionResult Index()
        {
            var lebron = new Athlete
            {
                Name = "LeBron James",
                Sport = "Basketball",
                Biography = "LeBron James is an American professional basketball player for the Los Angeles Lakers of the NBA. He is widely regarded as one of the greatest players in basketball history.",
                PhotoUrls = new List<string>
                {
                    "https://cdn.nba.com/headshots/nba/latest/1040x760/2544.png",
                    "https://www.lebronjames.com/dA/14ce536824/lbj_share.jpg",
                    "https://ca-times.brightspotcdn.com/dims4/default/09a675a/2147483647/strip/true/crop/6313x4211+0+0/resize/1200x800!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F1a%2F7d%2F3c671d3d47dcbe28498ed777e4c4%2Flakers-rockets-basketball-85461.jpg",
                    "https://ca-times.brightspotcdn.com/dims4/default/2f04999/2147483647/strip/true/crop/3632x2421+0+0/resize/2000x1333!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fd4%2F3c%2F617f46b34b52b99c6d53665f59e8%2F1493268-sp-lakers-warriors-nba-wjs001.jpg"
                }
            };

            return View(lebron);
        }
    }
}
