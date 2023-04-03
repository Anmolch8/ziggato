using System.ComponentModel.DataAnnotations;
using ziggato.Models;


namespace ziggato.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        
        public int ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }

}