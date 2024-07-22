using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class CartDbContext:DbContext
    {
        public CartDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Role> Roles { get; set; }
    }
}
