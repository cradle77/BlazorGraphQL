using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using System.Linq;

namespace GqlDemo.Server.Queries
{
    public class SharesQuery
    {
        [GraphQLName("industries")]
        [UseDbContext(typeof(MyContext))]
        public IQueryable<Industry> GetAllIndustries([ScopedService] MyContext dbcontext)
        {
            return dbcontext.Industries;
        }

        [GraphQLName("shares")]
        [UseDbContext(typeof(MyContext))]
        [UsePaging, UseFiltering, UseSorting]
        public IQueryable<Share> GetAllShares([ScopedService] MyContext dbcontext)
        {
            return dbcontext.Shares;
        }
    }
}
