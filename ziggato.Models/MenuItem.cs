using ziggato.Models;


namespace ziggato.Models
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public int ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }

}