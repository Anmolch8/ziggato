using System;
using System.ComponentModel.DataAnnotations;

namespace ziggato.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        public int CouponDiscountAmount { get; set; }
        public bool IsCouponExpired { get; set; }

    }
}
