using System;

namespace ziggato.Models
{
    public class Restaurant
    {

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string RestaurantCity { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime CloseingTime { get; set; }
        public string RestaurantType { get; set; }
        public bool isActive { get; set; }
        public List<MenuItem> Menu { get; set; }


    }
}

