using GqlDemo.InvestorsServer.Data;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Pagination;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace GqlDemo.InvestorsServer.Security
{
    public class ColumnLevelAuthorizeAttribute : DescriptorAttribute
    {
        protected override void TryConfigure(IDescriptorContext context, IDescriptor descriptor, ICustomAttributeProvider element)
        {
            if (descriptor is IObjectFieldDescriptor ofd)
            {
                ofd.Use<ColumnLevelAuthorizeMiddleware>();
            }
        }
    }

    internal class ColumnLevelAuthorizeMiddleware
    {
        private FieldDelegate _next;
        public ColumnLevelAuthorizeMiddleware(
            FieldDelegate next)
        {
            _next = next;
        }

        public async ValueTask InvokeAsync(IMiddlewareContext context)
        {
            await _next(context).ConfigureAwait(false);

            var httpContext = (HttpContext)context.ContextData["HttpContext"];

            if (!httpContext.User.Identity.IsAuthenticated)
            {
                if (context.Result is IEnumerable<Investor> investors)
                {
                    foreach (var item in investors)
                    {
                        item.NetWorth = 0;
                    }
                }
            }
        }
    }
}
