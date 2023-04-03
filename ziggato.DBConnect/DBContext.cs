using Microsoft.EntityFrameworkCore;
using ziggato.Models;

namespace ziggato.DBConnect
{
    public class ZiggatoDatabaseContext : DbContext
    {
        public ZiggatoDatabaseContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
        }


        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBill> OrderBills { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
