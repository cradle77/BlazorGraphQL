using Microsoft.EntityFrameworkCore;

namespace GqlDemo.Server.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Share> Shares { get; set; }

        public DbSet<Industry> Industries { get; set; }
    }
}
