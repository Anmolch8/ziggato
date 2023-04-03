using System;

namespace ziggato.Models
{
    public class OrderBill
    {
        public string OrderName { get; set; } = string.Empty;
        public string OrderType { get; set; } = string.Empty;
        public int OrderFinalPrice { get; set;}
        
    }
}
