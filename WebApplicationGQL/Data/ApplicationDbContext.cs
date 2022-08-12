using Microsoft.EntityFrameworkCore;

namespace WebApplicationGQL.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cake> Cake { get; set; }
    }
}
