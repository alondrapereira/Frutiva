using Frutiva.Models;
using Microsoft.EntityFrameworkCore;

namespace Frutiva.Data
{
    public class FrutivaDbContext : DbContext
    {
        public FrutivaDbContext()
        {
        }
        public FrutivaDbContext(DbContextOptions<FrutivaDbContext> options) : base(options)
        {
        }
        public DbSet<Bowl> Bowls { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}