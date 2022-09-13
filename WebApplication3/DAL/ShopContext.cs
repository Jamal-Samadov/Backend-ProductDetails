using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
                
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
