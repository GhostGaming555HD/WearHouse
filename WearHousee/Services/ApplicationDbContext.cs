using Microsoft.EntityFrameworkCore;
using WearHousee.Models;

namespace WearHousee.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Product> product {  get; set; }
    }
}
