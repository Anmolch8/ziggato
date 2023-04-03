using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziggato.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public int CouponDiscountAmount { get; set; }
        public bool IsCouponExpired { get; set; }

    }
}
