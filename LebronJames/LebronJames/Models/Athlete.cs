using System.Collections.Generic;

namespace LebronJames.Models
{
    public class Athlete
    {
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Biography { get; set; }
        public List<string> PhotoUrls { get; set; }
    }
}
