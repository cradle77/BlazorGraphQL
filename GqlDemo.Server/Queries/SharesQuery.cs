using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GqlDemo.Server.Queries
{
    public class SharesQuery
    {
        [GraphQLName("shares")]
        [UsePaging(IncludeTotalCount = true), UseFiltering, UseSorting]
        public IEnumerable<Share> GetAllShares()
        {
            yield return new Share()
            {
                Id = 1,
                CompanyName = "Micro software",
                Industry = new Industry { Id = 1, Name = "Technology" },
                Value = 55.3m
            };

            yield return new Share()
            {
                Id = 2,
                CompanyName = "Go Gol",
                Industry = new Industry { Id = 1, Name = "Technology" },
                Value = 23.5m
            };

            yield return new Share()
            {
                Id = 3,
                CompanyName = "Ama's son",
                Industry = new Industry { Id = 2, Name = "Retail" },
                Value = 63.9m
            };

            yield return new Share()
            {
                Id = 4,
                CompanyName = "Pizza ciro",
                Industry = new Industry { Id = 3, Name = "Hospitality" },
                Value = 19.7m
            };
        }
    }
}
