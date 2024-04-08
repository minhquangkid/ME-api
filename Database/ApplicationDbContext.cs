using ME_api.Models;
using Microsoft.EntityFrameworkCore;

namespace ME_api.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<MainCategory> MainCategories { get; set;}

    }
}
