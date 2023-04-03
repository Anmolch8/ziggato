using System;
using System.ComponentModel.DataAnnotations;

namespace ziggato.Models
{
    public class OrderBill
    {
        [Key]
        public int OrderBillId { get; set; }
        public string OrderName { get; set; } = string.Empty;
        public string OrderType { get; set; } = string.Empty;
        public int OrderFinalPrice { get; set;}
        
    }
}
