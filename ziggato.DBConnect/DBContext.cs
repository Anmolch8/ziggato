using Microsoft.EntityFrameworkCore;
using ziggato.Models;

namespace ziggato.DBConnect
{
    public class ZiggatoDatabaseContext : DbContext
    {
        public ZiggatoDatabaseContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
        }


        public DbSet<Restraunt> Restraunts { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

       
    }
}
