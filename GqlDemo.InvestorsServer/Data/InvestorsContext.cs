using Microsoft.EntityFrameworkCore;

namespace GqlDemo.InvestorsServer.Data
{
    public class InvestorsContext : DbContext
    {
        public InvestorsContext(DbContextOptions<InvestorsContext> options)
            : base(options)
        {
        }

        public DbSet<Investor> Investors { get; set; }
    }
}
