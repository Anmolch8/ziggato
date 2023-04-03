using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziggato.Models
{
    public class OrderBill
    {
        public string OrderName { get; set; } = string.Empty;
        public string OrderType { get; set; } = string.Empty;
        public int OrderFinalPrice { get; set;}
        
    }
}
