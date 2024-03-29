﻿using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        [GraphQLName("industryById")]
        [UseDbContext(typeof(MyContext))]
        public async Task<Industry> GetIndustry([ScopedService] MyContext dbcontext, int id, 
            IResolverContext context, CancellationToken token)
        {
            return await context.BatchDataLoader<int, Industry>(async (ids, ct) =>
            {
                var result = await dbcontext.Industries
                    .Where(x => ids.Contains(x.Id))
                    .ToListAsync();

                return result.ToDictionary(x => x.Id);
            })
                .LoadAsync(id, token);
        }

        [GraphQLName("shares")]
        [UseDbContext(typeof(MyContext))]
        [UsePaging(IncludeTotalCount = true, MaxPageSize = 100), UseFiltering, UseSorting]
        public IQueryable<Share> GetAllShares([ScopedService] MyContext dbcontext, int? industryId)
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
