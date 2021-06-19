using GqlDemo.InvestorsServer.Data;
using HotChocolate;
using System.Linq;

namespace GqlDemo.InvestorsServer.Queries
{
    public class InvestorsQuery
    {
        [GraphQLName("investors")]
        public IQueryable<Investor> GetAllIndustries()
        {
            return new[] 
            {
                new Investor() { Id = 1, Name = "Marco", NetWorth = 1000000 },
                new Investor() { Id = 1, Name = "Daniele", NetWorth = 5000000 }
            }.AsQueryable();
        }
    }
}
