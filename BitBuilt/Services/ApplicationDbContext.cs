using BitBuilt.Models;
using Microsoft.EntityFrameworkCore;

namespace BitBuilt.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet <Product> Products { get; set; }
    }
}
