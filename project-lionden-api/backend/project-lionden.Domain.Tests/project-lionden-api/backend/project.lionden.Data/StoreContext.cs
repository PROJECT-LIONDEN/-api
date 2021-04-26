using project.lionden.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
 
namespace project.lionden.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        { }
 
        public DbSet<Item> Items {get; set; }
        public DbSet<Order> Orders {get; set;}
    }

}
