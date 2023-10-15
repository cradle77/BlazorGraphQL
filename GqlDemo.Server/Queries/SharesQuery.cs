using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GqlDemo.Server.Queries
{
    public class SharesQuery
    {
        [GraphQLName("industries")]
        public IQueryable<Industry> GetAllIndustries(MyContext dbcontext)
        {
            return dbcontext.Industries;
        }

        [GraphQLName("shares")]
        [UsePaging(IncludeTotalCount = true, MaxPageSize = 100), UseProjection, UseFiltering, UseSorting]
        public IQueryable<Share> GetAllShares(MyContext dbcontext, int? industryId)
        {
            var query = dbcontext.Shares.Include(x => x.Industry).AsQueryable();

            if (industryId != null)
            {
                query = query.Where(x => x.Industry.Id == industryId);
            }

            return query;
        }
    }
}
