using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziggato.Models

{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderAdderss { get; set; } = string.Empty;
        public string OrderPaymentType { get; set; } = string.Empty;

        bool IsCouponApplied { get; set; }

        Restaurant ChoosenRestaurant { get; set; }

        list<MenuItem> MenuItemList { get; set; }

        OrderBill Bill { get; set; }

        Coupon CouponObj { get; set; }


    }
}