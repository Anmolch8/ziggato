using System;
using System.ComponentModel.DataAnnotations;

namespace ziggato.Models

{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderAdderss { get; set; } = string.Empty;
        public string OrderPaymentType { get; set; } = string.Empty;

        bool IsCouponApplied { get; set; }

        public Restaurant ChoosenRestaurant { get; set; }

        public List<MenuItem> MenuItemList { get; set; }

        public OrderBill Bill { get; set; }

        public Coupon CouponObj { get; set; }


    }
}