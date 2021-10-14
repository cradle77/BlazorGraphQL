using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GqlDemo.Server.Subscriptions
{
    public class SharesSubscription
    {
        [Subscribe]
        [Topic]
        [UseDbContext(typeof(MyContext))]
        public Task<Share> OnShareValueChangedAsync(
            [EventMessage] int shareId,
            [ScopedService] MyContext dbcontext,
            CancellationToken cancellationToken)
        {
            return dbcontext.Shares
                .Include(x => x.Industry)
                .SingleAsync(x => x.Id == shareId);
        }

        [Subscribe]
        [UseDbContext(typeof(MyContext))]
        public Task<Share> OnShareValueChangedByIndustryAsync(
            [Topic] string industry,
            [EventMessage] int shareId,
            [ScopedService] MyContext dbcontext,
            CancellationToken cancellationToken)
        {
            return dbcontext.Shares
                .Include(x => x.Industry)
                .SingleAsync(x => x.Id == shareId);
        }
    }
}
