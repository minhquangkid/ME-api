using Microsoft.EntityFrameworkCore;

namespace ME_api.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

    }
}
