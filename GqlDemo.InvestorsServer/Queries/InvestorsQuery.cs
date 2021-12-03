using GqlDemo.InvestorsServer.Data;
using GqlDemo.InvestorsServer.Security;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using System.Linq;

namespace GqlDemo.InvestorsServer.Queries
{
    public class InvestorsQuery
    {
        /* 
         $token = az account get-access-token --resource api://advancedtestdemo/bankapi | ConvertFrom-Json
         $token.AccessToken | Set-Clipboard
         */
        [GraphQLName("investors")]
        //[ColumnLevelAuthorize]
        [Authorize]
        public IQueryable<Investor> GetAllIndustries()
        {
            return new[] 
            {
                new Investor() { Id = 1, Name = "John", NetWorth = 1000000, IndustryId = 1 },
                new Investor() { Id = 1, Name = "Daniel", NetWorth = 5000000, IndustryId = 2 },
                new Investor() { Id = 1, Name = "Andrew", NetWorth = 3000000, IndustryId = 2 }
            }.AsQueryable();
        }
    }
}
