using System;


namespace ziggato.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public int CouponDiscountAmount { get; set; }
        public bool IsCouponExpired { get; set; }

    }
}
